using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.UserControls.TacNghiep.Checkin.HoiVien
{
    public partial class FrmKhachLe : Form
    {
        public FrmKhachLe()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int tien;
            var st = txtTien.Text;
            if (!int.TryParse(st, out tien) || tien <= 0 || tien % 500 != 0) {
                dxErrorProvider1.SetError(txtTien, "Tiền nhập vào không hợp lệ");
                txtTien.Focus();
                return;
            }

        }
    }
}
