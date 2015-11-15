using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.DataFiller;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.View.Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.UserControls.QuanLy
{
    public partial class QLPhongTap : UserControl
    {
        List<PhongTap> all;

        public QLPhongTap()
        {
            InitializeComponent();
            dgrHoiVien.AutoGenerateColumns = false;
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmPhongTapEdit f = new FrmPhongTapEdit();
            if (f.ShowDialog() == DialogResult.OK) {
                loadData();
            }
        }

        void loadData()
        {

            all = PhongTapController.GetList();
            dgrHoiVien.DataSource = all;
            txtTim.Text = "";
        }

        void updateTable(List<PhongTap> li)
        {
            dgrHoiVien.DataSource = li;
        }

        private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (dgrHoiVien.SelectedRows.Count > 0)
            {
                var h = (PhongTap)dgrHoiVien.SelectedRows[0].DataBoundItem;
                if (!PhongTapController.IsKhongRangBuoc(h))
                {
                    MessageBox.Show("Không thể xóa do còn dữ liệu liên quan");
                    return;
                }
                if (h.MaPhongTap == Login1.GetPhongHienTai().MaPhongTap) {
                    MessageBox.Show("Không thể xóa phòng đang đăng nhập");
                    return;
                }
                if (PhongTapController.Delete(h.MaPhongTap) == CODE_RESULT_RETURN.ThanhCong)
                {
                    loadData();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa");

                }
            }
            else
            {
                MessageBox.Show("Chọn một phòng để xóa");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgrHoiVien.SelectedRows.Count > 0)
            {
                var h = (PhongTap)dgrHoiVien.SelectedRows[0].DataBoundItem;
                FrmPhongTapEdit f = new FrmPhongTapEdit(h);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    loadData();
                }
               
            }
            else
            {
                MessageBox.Show("Chọn một sản phẩm để chỉnh sửa");
            }
        }

 
    }
}
