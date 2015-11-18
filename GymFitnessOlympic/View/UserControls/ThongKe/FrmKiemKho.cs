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
using GymFitnessOlympic.Models.Util;

namespace GymFitnessOlympic.View.ActForm
{
    public partial class FrmKiemKho : DevExpress.XtraEditors.XtraUserControl
    {
        PhongTap phongHienTai;

        public FrmKiemKho(PhongTap phong = null)
        {
            InitializeComponent();
            phongHienTai = phong != null ? phong : Login1.GetPhongHienTai();
            dataGridView1.AutoGenerateColumns = false;
            loc();
           
        }

     

        void loc()
        {
      
            var maPhong = phongHienTai != null ? phongHienTai.MaPhongTap : -1;
            try
            {
                
                List<ThongKeSoLuongModel> tks = SanPhamController.ThongKeSoLuong(phongHienTai);
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

      private void groupBox1_Enter(object sender, EventArgs e)
      {

      }
    }
}
