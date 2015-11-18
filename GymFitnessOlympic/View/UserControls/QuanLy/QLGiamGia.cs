using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.View.Dialog;
using GymFitnessOlympic.View.Utils;
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
    public partial class QLGiamGia : UserControl
    {
        public QLGiamGia()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            LoadData();
        }

        void LoadData() {
            var ggs = GiamGiaController.GetList();
            dataGridView1.DataSource = ggs;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) {
                var g = (GiamGia)dataGridView1.SelectedRows[0].DataBoundItem;
                if (!GiamGiaController.IsKhongRangBuoc(g)) {
                    DialogUtils.ShowMessage("Không thể xóa do còn ràng buộc về dữ liệu");
                    return;
                }
                if (DialogUtils.Confirmed("Bạn có thực sự muốn xóa") != true) {
                    return;
                }
                if (GiamGiaController.Delete(g.MaGiamGia) == CODE_RESULT_RETURN.ThanhCong)
                {
                    LoadData();
                }
                else {
                    MessageBox.Show("Có lỗi khi xóa");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmGiamGiaEdit f = new FrmGiamGiaEdit();
            if (f.ShowDialog() == DialogResult.OK) {
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) {
                var gg = (GiamGia)dataGridView1.SelectedRows[0].DataBoundItem;
                FrmGiamGiaEdit f = new FrmGiamGiaEdit(gg);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
    }
}
