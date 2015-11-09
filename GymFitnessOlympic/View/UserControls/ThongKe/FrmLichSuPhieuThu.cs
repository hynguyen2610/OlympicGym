﻿using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.DataFiller;
using GymFitnessOlympic.Models.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.ActForm
{
    public partial class FrmLichSuPhieuThu : UserControl
    {
        NhanVien nhanVienHienTai ;
        PhongTap phongHienTai;
        List<PhieuThu> allPhieuThu;

        public FrmLichSuPhieuThu(NhanVien _maNV = null)
        {
            InitializeComponent();
            nhanVienHienTai = _maNV;
            dataGridView1.AutoGenerateColumns = false;
            for (int i = 2010; i < 2250; i++)
            {
                cbbTheoThangNam.Items.Add(i);

            }
         
            phongHienTai = Login1.GetPhongHienTai();
            cbbPhong.Properties.NullText = "Chọn một phòng";
            DataFiller.fillPhongCombo(cbbPhong);
            cbbPhong.EditValue = phongHienTai.MaPhongTap;
            
            //loadData();
            loc();
            loadEnable();
        }

        void loadEnable() {
            cbbPhong.Enabled = nhanVienHienTai == null;
        }

      

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbbPhong.SelectedItem == null) {
                cbbPhong.Focus();
                dxErrorProvider1.SetError(cbbPhong,"Chưa chọn phòng");
                return;
            }
            loc();
        }

        void loc()
        {
            //var maPhong =Convert.ToInt32( cbbPhong.SelectedItem);
            try
            {
                phongHienTai = (PhongTap)cbbPhong.SelectedItem;
            }
            catch { }
            allPhieuThu = PhieuThuController.GetList(phongHienTai.MaPhongTap, nhanVienHienTai);
            try
            {
                DateTime start = new DateTime(), end = new DateTime();
                if (rdTheoThang.Checked)
                {
                    int month = int.Parse(cbbTheoThangThang.Text.ToString());
                    int year = int.Parse(cbbTheoThangNam.Text.ToString());
                    start = new DateTime(year, month, 1);
                    end = start.AddMonths(1).AddDays(-1);
                }
                
                else if (rdTheoKhoangNgay.Checked)
                {
                    start = dtpFrom.Value;
                    end = dtpTo.Value;
                }
                List<PhieuThu> li = new List<PhieuThu>();


                li = allPhieuThu.Where(h => h.NgayLap.CompareTo(start) >= 0 && h.NgayLap.CompareTo(end) <= 0).ToList();
                dataGridView1.DataSource = li;
            }
            catch { }
        }

        private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPhong.SelectedItem != null)
            {
               // phongHienTai = (PhongTap)cbbPhong.SelectedItem;
            }
        }
    }
}
