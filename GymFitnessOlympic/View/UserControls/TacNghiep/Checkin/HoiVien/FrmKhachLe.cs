using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models.entity;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.Utils;
using GymFitnessOlympic.View.Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.UserControls.TacNghiep.Checkin.HoiVien
{
    public partial class FrmKhachLe : UserControl
    {
        KhachLe kl;
        bool isValid = false;

        string giaGym1 = Properties.Settings.Default.GiaGym1;
        string giaGym2 = Properties.Settings.Default.GiaGym2;
        string giaSauna1 = Properties.Settings.Default.GiaSauna1;
        string giaSauna2 = Properties.Settings.Default.GiaSauna2;

        public FrmKhachLe()
        {
            InitializeComponent();
            loadCombo();
            loadData();
        }

        void loadCombo()
        {
            comboBox1.Items.Clear();
            if (rdChiGYM.Checked)
            {
                comboBox1.Items.AddRange(new object[] { giaGym1, giaGym2 });
            }
            else
            {
                comboBox1.Items.AddRange(new object[] { giaSauna1, giaSauna2 });
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            statusStrip1.Text = "";
            isValid = false;
            errorProvider1.Clear();
            int tien;
            var st = comboBox1.Text;
            if (comboBox1.Text == "") {
                errorProvider1.SetError(comboBox1, "Chưa nhập số tiền");
                comboBox1.Focus();
                return;
            }
            if (!int.TryParse(st, out tien) || tien <= 0 || tien % 500 != 0)
            {
                errorProvider1.SetError(comboBox1, "Tiền nhập vào không hợp lệ");
                comboBox1.Focus();
                return;
            }
            kl = new KhachLe()
             {
                 ThoiGian = DateTime.Now,
                 SoTien = tien,
                 NhanVien = Login1.TaiKhoanHienTai,
                 IsGYM = rdChiGYM.Checked
             };

            if (KhachLeController.Add(kl) == CODE_RESULT_RETURN.ThanhCong)
            {
                if (rdChiGYM.Checked)
                {
                    rdHisGym.Checked = true;
                }
                else if (rdChiSauna.Checked)
                {
                    rdHisSauna.Checked = true;
                }
                statusStrip1.Text = "Hoàn tất";
                comboBox1.Text = "";
                loadData();
                isValid = true;
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }

        void loadData()
        {
            var start = DateTimeUtil.StartOfDay(DateTime.Now);
            var end = DateTimeUtil.EndOfDay(DateTime.Now);
            int mode = rdHisCaHai.Checked ? 0 : rdHisGym.Checked ? 1 : 2;
            List<KhachLe> li = KhachLeController.ThongKe(start, end, Login1.TaiKhoanHienTai, mode);
            bindingSource1.DataSource = li;
            dataGridView1.DataSource = bindingSource1;
            lblTongTien.Text = li.Sum(c => c.SoTien).ToString().FormatCurrency().Trim() + "đ";
        }

        private void rdChiGYM_CheckedChanged(object sender, EventArgs e)
        {
            loadCombo();
        }

        private void rdChiSauna_CheckedChanged(object sender, EventArgs e)
        {
            loadCombo();
        }

        private void rdHisGym_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void rdHisSauna_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void rdHisCaHai_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnNhapIn_Click(object sender, EventArgs e)
        {
            btnNhap.PerformClick();
            if (isValid)
            {
                FrmViewerKhachLe f = new FrmViewerKhachLe(kl);
                f.ShowDialog();
            }
        }
    }
}
