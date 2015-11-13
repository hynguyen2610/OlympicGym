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
using GymFitnessOlympic.View.Utils;
using GymFitnessOlympic.Utils;

namespace GymFitnessOlympic.View.MainForms
{
    public partial class FrmCheckinHoiVien : UserControl
    {
        HoiVien hv;
        KetQuaCheckin validCardGYM = KetQuaCheckin.KhongTonTai;
        KetQuaCheckin validCardSauna = KetQuaCheckin.KhongTonTai;

        public FrmCheckinHoiVien(bool isGym = true)
        {
            InitializeComponent();
            loadDefault();
            dataGridView1.AutoGenerateColumns = false;
            loadGrid();
            lblThongBao.Text = "";
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {

            wipeCard();
        }

        void wipeCard()
        {


            loadDefault();
            var st = txtMa.Text;
            var his = HistoryHoiVienController.IsCheckedToDay(txtMa.Text.Trim());
            if (his != null)
            {
                DialogUtils.ShowMessage("Thẻ này đã được checkin trong ngày hôm nay!");
                return;
            }

            hv = HoiVienController.GetByMaHoiVien(txtMa.Text);
            if (hv != null)
            {
                //kiem tra gym
                if (hv.NgayHetHanGYM > DateTime.Now)
                {
                    validCardGYM = KetQuaCheckin.TheHopLe;

                }
                if (hv.NgayHetHanSauNa > DateTime.Now)
                {
                    validCardSauna = KetQuaCheckin.TheHopLe;

                }
                var hs = new HistoryHoiVien()
                {
                    HoiVien = hv,
                    ThoiGian = DateTime.Now,
                    IsDaInGYM = false,
                    IsDaInSauna = false
                };
                try
                {
                    if (HistoryHoiVienController.Add(hs) == CODE_RESULT_RETURN.ThanhCong)
                    {
                    }
                    loadData();
                }
                catch
                {
                    DialogUtils.ShowError("Có lỗi khi checkin");
                }

            }
            else
            {
                lblThongBao.Text = "Không tồn tại mã thẻ này";
            }
        }

        enum KetQuaCheckin
        {
            TheHopLe,
            KhongTonTai,
            DaHetHan
        }

        private void loadDefault()
        {
            lblThongBao.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMa.Text = "63fe8695-4f55-4483-a803-960788f860fa";
            //MessageBox.Show(lblChucNang.Text);
        }

        void loadData()
        {
            if (hv != null)
            {
                //Nap lai bang
                loadGrid();
                //Cập nhật text gymn
                lblPT_GiaHanCuoi.Text = DateTimeUtil.dateToString(hv.GiaHanCuoiGYM);
                lblPT_NgayHetHan.Text = DateTimeUtil.dateToString(hv.NgayHetHanGYM);
                var delta = Convert.ToInt32(Math.Ceiling((hv.NgayHetHanGYM - DateTime.Now).TotalDays));

                lblPT_SoNgayConLai.Text = (DateTime.Now.CompareTo(hv.NgayHetHanGYM) < 0) ?
                    delta.ToString() : "Đã hết hạn";

                if (validCardGYM == KetQuaCheckin.TheHopLe)
                {
                    lblKetQuaGYM.ForeColor = Color.Green;
                    lblKetQuaGYM.Text = "Thẻ hợp lệ";

                }
                else
                {
                    lblKetQuaGYM.ForeColor = Color.Red;
                    lblKetQuaGYM.Text = "Đã hết hạn";
                }
                //Cập nhật sauna
                lblSauGiaHanCuoi.Text = DateTimeUtil.dateToString(hv.GiaHanCuoiSauna);
                lblPT_NgayHetHan.Text = DateTimeUtil.dateToString(hv.NgayHetHanGYM);
                var deltaSauNa = Convert.ToInt32(Math.Ceiling((hv.NgayHetHanSauNa - DateTime.Now).TotalDays));

                lblSauSoNgayConLai.Text = (DateTime.Now.CompareTo(hv.NgayHetHanSauNa) < 0) ?
                    delta.ToString() : "Đã hết hạn";

                if (validCardSauna == KetQuaCheckin.TheHopLe)
                {
                    lblKetQuaSauna.ForeColor = Color.Green;
                    lblKetQuaSauna.Text = "Thẻ hợp lệ";

                }
                else
                {
                    lblKetQuaSauna.ForeColor = Color.Red;
                    lblKetQuaSauna.Text = "Đã hết hạn";
                }
            }
        }

        void loadGrid()
        {
            var hs = HistoryHoiVienController.GetToDay();
            MySortableBindingList<HistoryHoiVien> li =
                new MySortableBindingList<HistoryHoiVien>(hs);
            dataGridView1.DataSource = li;
        }

        private void btnGiaHanGYM_Click(object sender, EventArgs e)
        {
            if (hv != null)
            {
                FrmGiaHan gh = new FrmGiaHan(hv, isGYM: true);
                if (gh.ShowDialog() == DialogResult.OK)
                {
                    wipeCard();
                }
            }
            else
            {
                MessageBox.Show("Chưa có hội viên checkin hiện tại để gia hạn");
            }
        }

        private void FrmCheckinHoiVien_Load(object sender, EventArgs e)
        {
        }

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                btnCheckin.PerformClick();
            }
        }

        private void btnInGYM_Click(object sender, EventArgs e)
        {
            yeuCauInPhieu(true);
        }

        void yeuCauInPhieu(bool isGYM)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var tenPhieu = isGYM ? "GYM" : "Sauna";
                var hs = (HistoryHoiVien)dataGridView1.SelectedRows[0].DataBoundItem;
                var hv = hs.HoiVien;
                if (hv.NgayHetHanGYM < DateTime.Now)
                {
                    DialogUtils.ShowMessage("Thẻ này đã hết hạn " + tenPhieu);
                    return;
                }

                if ((isGYM && hs.IsDaInGYM) || (!isGYM && hs.IsDaInSauna))
                {
                    DialogUtils.ShowMessage("Đã in phiếu " + tenPhieu + " cho thẻ này trong ngày hôm nay");
                    return ;
                }
                var r  =HistoryHoiVienController.InPhieuCoCapNhat(hs, isGYM);
                if (r == CODE_RESULT_RETURN.ThatBai) {
                    DialogUtils.ShowMessage("Có lỗi khi ghi dữ liệu");
                }
            }
            else
            {
                DialogUtils.ShowMessage("Vui lòng chọn bản ghi muốn in phiếu");
                return ;
            }

        }

        private void btnCheckin_Click_1(object sender, EventArgs e)
        {
            wipeCard();
        }

        private void btnGiaHanSauna_Click(object sender, EventArgs e)
        {
            if (hv != null)
            {
                FrmGiaHan gh = new FrmGiaHan(hv, isGYM: false);
                if (gh.ShowDialog() == DialogResult.OK)
                {
                    wipeCard();
                }
            }
            else
            {
                MessageBox.Show("Chưa có hội viên checkin hiện tại để gia hạn");
            }
        }

        private void btnInSauna_Click(object sender, EventArgs e)
        {
            yeuCauInPhieu(false);
        }
    }
}