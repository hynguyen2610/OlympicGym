using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
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
    public partial class QLGiamGia : Form
    {
        public QLGiamGia()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        void LoadData() {
            var ggs = GiamGiaController.GetList();
            dataGridView1.DataSource = ggs;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) {
                var g = (GiamGia)dataGridView1.SelectedRows[0].DataBoundItem;
                if (GiamGiaController.Delete(g.MaGiamGia) == CODE_RESULT_RETURN.ThanhCong)
                {
                    LoadData();
                }
                else {
                    MessageBox.Show("Có lỗi khi xóa");
                }
            }
        }
    }
}
