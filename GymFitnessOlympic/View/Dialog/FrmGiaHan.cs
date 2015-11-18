﻿using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.DataFiller;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.View.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.Dialog
{
    public partial class FrmGiaHan : BaseDialog
    {
        HoiVien hoiVien;

        public FrmGiaHan(HoiVien hv = null, bool isGYM = true)
        {
            if (hoiVien == null)
            {
                InitializeComponent();
                this.hoiVien = hv;
                DataFiller.fillGoiCombo(cbbGiaHanGoi, isGYM ? 1 : 2, hoiVien.PhongTap.MaPhongTap);
                cbbGiaHanGoi_SelectedIndexChanged(null, null);
            }
           
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if(cbbGiaHanGoi.SelectedItem == null){
                errorProvider1.SetError(cbbGiaHanGoi, "Chưa chọn gói để gia hạn");
                cbbGiaHanGoi.Focus();
                return;
            }
            int tien;
            if(txtGiaHanSoTien.Text == "" || !int.TryParse(txtGiaHanSoTien.Text, out tien)){
                errorProvider1.SetError(txtGiaHanSoTien, "Số tiền không hợp lệ");
                txtGiaHanSoTien.Focus();
                return;
            }
            try
            {
                var r1 = MessageBox.Show("Xác nhận gia hạn không?", "Yêu cầu xác nhận", MessageBoxButtons.OKCancel);
                if (r1 == DialogResult.OK)
                {
                    var g = (GoiTap)cbbGiaHanGoi.SelectedItem;
                    var soTien = int.Parse(txtGiaHanSoTien.Text);
                    PhieuThu p = new PhieuThu()
                    {
                        GoiTap = g,
                        HoiVien = hoiVien,
                        
                        NgayLap = DateTime.Now,
                        NhanVien = Login1.GetTaiKhoanHienTai(),
                        SoTien = soTien,
                        LyDo = txtLyDo.Text.Trim()
                    };
                    var r = PhieuThuController.Add(p);
                    if (r == CODE_RESULT_RETURN.ThanhCong)
                    {

                        //
                        //lblKetQuaGiaHan.Text = "Gia hạn thành công";
                        MessageBox.Show("Gia hạn thành công");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
            catch {
                DialogUtils.ShowError("Có lỗi khi gia hạn");
            }
        }

        private void cbbGiaHanGoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbGiaHanGoi.Items.Count > 0)
            {
                cbbGiaHanGoi.Enabled = txtGiaHanSoTien.Enabled = btnGiaHan.Enabled = true;
                var goi = (GoiTap)cbbGiaHanGoi.SelectedItem;
                txtGiaHanSoTien.Text = goi.Gia.ToString();
                var limit = hoiVien.NgayHetHanGYM.AddDays(goi.SoThang * 30);
                lblNgayHetHanDuKien.Text = DateTimeUtil.dateToString(limit);
            }
            else
            {
                cbbGiaHanGoi.Enabled = txtGiaHanSoTien.Enabled = btnGiaHan.Enabled = false;
                cbbGiaHanGoi.Text = "Không có gói thỏa mãn";
                txtGiaHanSoTien.Text = "0";
                lblNgayHetHanDuKien.Text = "Không rõ";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
