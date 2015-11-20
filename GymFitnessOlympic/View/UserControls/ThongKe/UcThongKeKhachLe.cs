using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymFitnessOlympic.Models.entity;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.View.Utils;
using GymFitnessOlympic.Utils;
using GymFitnessOlympic.Models.DataFiller;

namespace GymFitnessOlympic.View.UserControls.ThongKe
{
    public partial class UcThongKeKhachLe : UserControl
    {
        NhanVien nhanVienHienTai;

        public UcThongKeKhachLe(NhanVien nv = null)
        {
            InitializeComponent();
            //var nvs = NhanVienController.GetList(Login1.GetPhongHienTai().MaPhongTap);
            //nvs.Insert(0, new NhanVien() { MaNhanVien =-1, TenNhanVien = "--Tất cả--"});
            //cbbNhanVien.DataSource = nvs;
            //cbbNhanVien.DisplayMember = "TenNhanVien";
            //cbbNhanVien.ValueMember = "MaNhanVien";
            DataFiller.fillPhongCombo(cbbPhong, append: true);
            var phong =(PhongTap) cbbPhong.SelectedItem;
            DataFiller.fillNhanVienCombo(cbbNhanVien, phong.MaPhongTap, append: true);
            dataGridView1.AutoGenerateColumns = false;
            cbbNhanVien.SelectedIndex = 0;
            nhanVienHienTai = nv;
            if (nv != null)
            {
                cbbNhanVien.SelectedValue = nv.MaNhanVien;
            }
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cbbNhanVien.SelectedItem != null)
            {
                var phong = (PhongTap)cbbPhong.SelectedItem;
                var nhanVienLap = (NhanVien)cbbNhanVien.SelectedItem;
                var start = DateTimeUtil.StartOfDay(dtpFrom.Value);
                var end = DateTimeUtil.EndOfDay(dtpTo.Value);
                int mode = rdCaHai.Checked ? 0 : rdChiGYM.Checked ? 1 : 2;
                List<KhachLe> li = KhachLeController.ThongKe(start, end,phong,  nhanVienLap, mode);
                bindingSource1.DataSource = li;
                dataGridView1.DataSource = bindingSource1;

                lblTongTien.Text = li.Sum(c => c.SoTien).ToString().FormatCurrency().Trim() + "đ";
            }
            else
            {
                DialogUtils.ShowError("Chưa chọn nhân viên");
            }
        }

        private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbPhong.SelectedItem != null){
                var p = (PhongTap)cbbPhong.SelectedItem;
                DataFiller.fillNhanVienCombo(cbbNhanVien, p.MaPhongTap, append: true);
            }
        }


    }
}
