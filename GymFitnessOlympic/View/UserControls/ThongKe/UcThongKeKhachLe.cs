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

namespace GymFitnessOlympic.View.UserControls.ThongKe
{
    public partial class UcThongKeKhachLe : UserControl
    {
        NhanVien nhanVienHienTai;

        public UcThongKeKhachLe(NhanVien nv = null)
        {
            InitializeComponent();
            var nvs = NhanVienController.GetList(Login1.GetPhongHienTai().MaPhongTap);
            nvs.Insert(0, new NhanVien() { MaNhanVien =-1, TenNhanVien = "--Tất cả--"});
            cbbNhanVien.DataSource = nvs;
            cbbNhanVien.DisplayMember = "TenNhanVien";
            cbbNhanVien.ValueMember = "MaNhanVien";
            dataGridView1.AutoGenerateColumns = false;
            cbbNhanVien.SelectedIndex = 0;
            nhanVienHienTai = nv;
            if (nv != null) {
                cbbNhanVien.Enabled = false;
                foreach (var nv1 in nvs)
                {
                    if (nv1.MaNhanVien == nv.MaNhanVien)
                    {
                        cbbNhanVien.SelectedValue = nv.MaNhanVien;
                        break;
                    }
                }
                
            }
        }

        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cbbNhanVien.SelectedItem != null)
            {
                var nv1 = (NhanVien)cbbNhanVien.SelectedItem;
                var start = DateTimeUtil.StartOfDay(dtpFrom.Value);
                var end = DateTimeUtil.EndOfDay(dtpTo.Value);
                int mode = rdCaHai.Checked ? 0 : rdChiGYM.Checked ? 1 : 2;
                List<KhachLe> li = KhachLeController.ThongKe(start, end, nv1, mode);
                bindingSource1.DataSource = li;
                dataGridView1.DataSource = bindingSource1;

                lblTongTien.Text = li.Sum(c => c.SoTien).ToString().FormatCurrency().Trim() +"đ";
            }
            else {
                DialogUtils.ShowError("Chưa chọn nhân viên");
            }
        }


    }
}
