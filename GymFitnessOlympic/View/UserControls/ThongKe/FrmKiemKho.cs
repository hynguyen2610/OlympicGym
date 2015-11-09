using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.DataFiller;

namespace GymFitnessOlympic.View.ActForm
{
    public partial class FrmKiemKho : DevExpress.XtraEditors.XtraUserControl
    {
        PhongTap phongHienTai;

        public FrmKiemKho()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            rdTheoThang.Checked = true;
            loc();
            for (int i = 2010; i < 2100; i++ ) {
                cbbTheoThangNam.Items.Add(i);
            }
            DataFiller.fillPhongCombo(cbbPhong);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbbPhong.SelectedItem == null) {
                dxErrorProvider1.SetError(cbbPhong, "Chưa chọn phòng");
                cbbPhong.Focus();
                return;
            }
            loc();
        }

        void loc()
        {
            try
            {
                phongHienTai = (PhongTap)cbbPhong.SelectedItem;
            }
            catch
            {
            }
            var maPhong = phongHienTai != null ? phongHienTai.MaPhongTap : -1;
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
                List<ThongKeSoLuongModel> tks = SanPhamController.ThongKeSoLuong(start, end, phongHienTai);
                dataGridView1.DataSource = tks;
            }
            catch { }


        }

      public  class ThongKeSoLuongModel
        {
            public SanPham SanPham { get; set; }
            public int SoBan { get; set; }
            public int TienBan { get; set; }
            public int SoNhap { get; set; }
            public int TienNhap { get; set; }
            public int Ton
            {
                get
                {
                    return SoNhap - SoBan;
                }
            }
        }
    }
}
