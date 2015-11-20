using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.DataFiller;
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
        KhachLe khachLe;
        bool isValid = false;
        List<KhachLe> danhSachKhachLeTrongNgay = new List<KhachLe>();
        string giaGym1 = Properties.Settings.Default.GiaGym1;
        string giaGym2 = Properties.Settings.Default.GiaGym2;
        string giaSauna1 = Properties.Settings.Default.GiaSauna1;
        string giaSauna2 = Properties.Settings.Default.GiaSauna2;

        public FrmKhachLe()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            loadCombo();
            loadData();
            DataFiller.fillGiamGiaCombo(cbbGiamGiaGYM, true, true);

        }

        void loadCombo()
        {
            cbbSoTien.Items.Clear();
            if (rdChiGYM.Checked)
            {
                cbbSoTien.Items.AddRange(new object[] { giaGym1, giaGym2 });
            }
            else
            {
                cbbSoTien.Items.AddRange(new object[] { giaSauna1, giaSauna2 });
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Close();
        }

        void tinhTienPhaiTra()
        {
            try
            {
                int soTien = int.Parse(cbbSoTien.Text);
                var giamGia = (GiamGia)cbbGiamGiaGYM.SelectedItem;
                soTien = soTien - soTien * giamGia.PhanTramGiam / 100;
                lblTienPhaiTra.Text = soTien.ToString().FormatCurrency() + "đ";
            }
            catch { }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            statusStrip1.Text = "";
            isValid = false;
            errorProvider1.Clear();
            int tien;
            var st = cbbSoTien.Text;
            if (cbbSoTien.Text == "")
            {
                errorProvider1.SetError(cbbSoTien, "Chưa nhập số tiền");
                cbbSoTien.Focus();
                return;
            }
            if (!int.TryParse(st, out tien) || tien <= 0 || tien % 500 != 0)
            {
                errorProvider1.SetError(cbbSoTien, "Tiền nhập vào không hợp lệ");
                cbbSoTien.Focus();
                return;
            }
            var gg = (GiamGia)cbbGiamGiaGYM.SelectedItem;
            tien = tien - tien * gg.PhanTramGiam / 100;
            khachLe = new KhachLe()
             {
                 ThoiGian = DateTime.Now,
                 SoTien = tien,
                 NhanVien = Login1.TaiKhoanHienTai,
                 IsGYM = rdChiGYM.Checked,

             };

            if (cbbGiamGiaGYM.SelectedIndex > 0)
            {
                khachLe.GiamGia = (GiamGia)cbbGiamGiaGYM.SelectedItem;
            }
            if (KhachLeController.Add(khachLe) == CODE_RESULT_RETURN.ThanhCong)
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
                cbbSoTien.Text = "";
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
            danhSachKhachLeTrongNgay = KhachLeController.ThongKe(start, end,Login1.GetPhongHienTai(), Login1.TaiKhoanHienTai, mode);
            bindingSource1.DataSource = danhSachKhachLeTrongNgay;
            dataGridView1.DataSource = bindingSource1;
            updateTienTrongNgay();
        }

        void updateTienTrongNgay()
        {
            try
            {
                var tien = danhSachKhachLeTrongNgay.Sum(c => c.SoTien);

                lblTongTien.Text = tien.ToString().FormatCurrency().Trim() + "đ";
            }
            catch { }
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
                FrmInPhieu f = new FrmInPhieu(khachLe);
               // f.ShowDialog();
            }
        }

        private void cbbGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            tinhTienPhaiTra();
        }

        private void cbbSoTien_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                tinhTienPhaiTra();
            }
            catch { }
        }
    }
}
