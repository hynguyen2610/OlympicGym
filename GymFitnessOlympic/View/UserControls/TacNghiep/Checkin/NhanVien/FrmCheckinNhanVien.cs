using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.View.Dialog;
using GymFitnessOlympic.Properties;
using GymFitnessOlympic.Utils;

namespace GymFitnessOlympic.View.MainForms
{
    public partial class FrmCheckinNhanVien :UserControl
    {
        NhanVien nv;
        List<HistoryNhanVien> listTrongNgay = new List<HistoryNhanVien>();
        bool isCheckin = true;
        public FrmCheckinNhanVien(bool isCheckin = true)
        {
            InitializeComponent();
            this.isCheckin = isCheckin;
            dataGridViewEx1.AutoGenerateColumns = false;
            dataGridViewEx1.Columns[2].HeaderText = isCheckin ?
                "Thời gian checkin" : "Thời gian checkout";
            dataGridViewEx1.Columns[3].HeaderText = isCheckin ?
                "Số phút trễ" : "Số phút sớm";
            lblTenDanhSach.Text += isCheckin ? " checkin trong ngày" : " checkout trong ngày";
            if (!isCheckin) {
                lblHeader.Text = "Checkout nhân viên";
            }
            loadDefault();
            loadGrid();
        }

        private void loadGrid()
        {
            listTrongNgay = HistotyNhanVienController.GetToDay(Login1.GetPhongHienTai().MaPhongTap, isCheckin, Login1.CaHienTai);
            dataGridViewEx1.DataSource = listTrongNgay;
        }

        string getTenHanhDong(int n = -1) {
             if(n!= -1){
                 return n == 0 ? "checkin":"checkout";
            }
            return isCheckin ? "checkin" : "checkout";
           
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {

            wipeCard();
        }

        void loadData() {
            lblTenNhanVien.Text = nv.TenNhanVien;
            lblPhongTap.Text = (nv.PhongTap.TenPhongTap);
            lblNgaySinh.Text = nv.NgaySinh.ToString().DateToText();            
            if(nv.Anh !=null){
                pictureBox1.Image = StreamUtil.byteArrayToImage(nv.Anh);
            }
            loadGrid();
        }

        void wipeCard() {
            loadDefault();
            var checkin = isCheckin;
            nv = NhanVienController.GetByMaThe(txtMa.Text.Trim());
            if (nv != null)
            {
                if (checkin)
                {
                    if (!NhanVienController.IsCheckedIn(nv.MaThe))
                    {
                        var hh = new HistoryNhanVien()
                        {
                            IsCheckin = true,
                            NhanVien = nv,
                            ThoiGian = DateTime.Now,
                            Ca = Login1.CaHienTai
                        };
                        var r = HistotyNhanVienController.Add(hh);
                        if (r == CODE_RESULT_RETURN.ThanhCong)
                        {
                            loadData();
                            lblKetQua.Text = "Đã "+getTenHanhDong();
                            lblKetQua.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblKetQua.Text = "Có lỗi khi "+getTenHanhDong();
                            lblKetQua.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        thongBaoDaLam();
                    }
                }
                else { 
                    //Nguoi dung checkout
                    if (!NhanVienController.IsCheckedOut(nv.MaThe))
                    {
                        var hh = new HistoryNhanVien()
                        {
                            IsCheckin = false,
                            NhanVien = nv,
                            ThoiGian = DateTime.Now,
                            Ca = Login1.CaHienTai
                        };
                        var r = HistotyNhanVienController.Add(hh);
                        if (r == CODE_RESULT_RETURN.ThanhCong)
                        {
                            loadData();
                            lblKetQua.Visible = true;
                            lblKetQua.Text = "Đã checkout";
                            lblKetQua.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblKetQua.Text = "Có lỗi khi checkout";
                            lblKetQua.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        //lblKetQua.ForeColor = Color.Purple;
                        //lblKetQua.Text = "Nhân viên này đã checkout, chưa checkin";
                        //loadData();
                        thongBaoDaLam();
                    }
                }
            }
            else
            {
                lblKetQua.ForeColor = Color.Red;
                lblKetQua.Text = "Không có nhân viên này";
            }
            
        }

        private void thongBaoDaLam()
        {
            lblKetQua.ForeColor = Color.Purple;
            int n = isCheckin ? 0 : 1;
            lblKetQua.Text = "Nhân viên này đã " + getTenHanhDong(n) + ", chưa " + getTenHanhDong(Math.Abs(1 - n));
            loadData();
        }

        private void loadDefault()
        {
            lblKetQua.Text = "";
            lblPhongTap.Text = lblTenNhanVien.Text = lblNgaySinh.Text = "Không rõ";
            pictureBox1.Image = Resources.empty_avatar;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMa.Text = "63fe8695-4f55-4483-a803-960788f860fa";
        }



      

        private void btnCheckin_Click_1(object sender, EventArgs e)
        {
            if (txtMa.Text.Length > 100) {
                errorProvider1.SetError(txtMa, "Độ dài dữ liệu nhập vào quá lớn");
                txtMa.Focus();
                return;
            }
            wipeCard();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            wipeCard();
        }

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnCheckin.PerformClick();
                txtMa.Text = "";

            }
        }
    }
}