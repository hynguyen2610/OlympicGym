using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymFitnessOlympic.View.Utils;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.View.Dialog;
using GymFitnessOlympic.Utils;

namespace GymFitnessOlympic.View.UserControls.ThongKe
{
    public partial class FrmDangKyNhanh : UserControl
    {
        public FrmDangKyNhanh()
        {
            InitializeComponent();
            dgrDangKy.AutoGenerateColumns = false;
            loadCombo();
            loadData();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            lblThanhCong.Visible = false;
            dxErrorProvider1.ClearErrors();

            if (txtMaThe.Text == "")
            {
                errorProvider1.SetError(txtMaThe, "Mã thẻ không được trống");
                txtMaThe.Focus();
                return;
            }
            if (txtHoTen.Text == "")
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được trống");
                txtHoTen.Focus();
                return;
            }
            var g1 = (GoiTap)cbbGoiGym.SelectedItem;
            var g2 = (GoiTap)cbbGoiSauna.SelectedItem;
            if (g1.MaGoiTap == -1 && g2.MaGoiTap == -1)
            {
                DialogUtils.ShowMessage("Cần chọn ít nhất gói GYM hoặc gói Sauna");
                return;
            }
            //
            if (txtHoTen.Text == "")
            {
                dxErrorProvider1.SetError(txtHoTen, "Họ tên không được trống");
                txtHoTen.Focus();
                return;
            }
            if (txtMaThe.Text == "")
            {
                dxErrorProvider1.SetError(txtHoTen, "Mã thẻ không được trống");
                txtHoTen.Focus();
                return;
            }
            var hv = new HoiVien()
            {
                TenHoiVien = txtHoTen.Text.Trim(),
                MaGYM = txtMaThe.Text.Trim(),
                PhongTap = Login1.GetPhongHienTai(),
                NgayGioDangKy = DateTime.Now,
                NgaySinh = DateTime.Now,
                IsDangKyNhanh = true,

            };
            var r = HoiVienController.Add(hv);
            if (r != CODE_RESULT_RETURN.ThanhCong)
            {
                txtMaThe.Focus();
                lblThanhCong.Text = "";
            }
            if (g1.MaGoiTap != -1)
            {
                PhieuThu pt = new PhieuThu()
                {
                    GoiTap = g1,
                    HoiVien = hv,
                    NgayLap = DateTime.Now,
                    NhanVien = Login1.TaiKhoanHienTai,
                    SoTien = g1.Gia
                };
                PhieuThuController.Add(pt);
            }

            if (g2.MaGoiTap != -1)
            {
                PhieuThu pt = new PhieuThu()
                {
                    GoiTap = g2,
                    HoiVien = hv,
                    NgayLap = DateTime.Now,
                    NhanVien = Login1.TaiKhoanHienTai,
                    SoTien = g1.Gia
                };
                PhieuThuController.Add(pt);
            }

            if (r == CODE_RESULT_RETURN.ThanhCong)
            {
                loadData();
                //DialogUtils.ShowMessage("Đăng ký nhanh hoàn tất");
                lblThanhCong.Visible = true;
                lblThanhCong.Text = "Đăng ký nhanh hoàn tất";
            }
            else if (r == CODE_RESULT_RETURN.MaTrung)
            {
                lblThanhCong.Visible = true;
                lblThanhCong.Text = "Mã hội viên này đã tồn tại";
                //DialogUtils.ShowError("Mã hội viên này đã tồn tại");
                return;
            }
        }

        void loadData()
        {
            List<HoiVien> li = HoiVienController.GetDangKyNhanhTrongNgay(Login1.GetPhongHienTai());
            dgrDangKy.DataSource = li;

        }

        void loadCombo()
        {
            var goiGyms = GoiTapController.GetByPhong(Login1.GetPhongHienTai(), 1);
            var goiSaunas = GoiTapController.GetByPhong(Login1.GetPhongHienTai(), 2);
            //
            goiGyms.Insert(0, new GoiTap()
            {
                MaGoiTap = -1,
                TenGoiTap = "--Vui lòng chọn gói--"
            });
            goiSaunas.Insert(0, new GoiTap()
            {
                MaGoiTap = -1,
                TenGoiTap = "--Vui lòng chọn gói--"
            });
            cbbGoiGym.DataSource = goiGyms;
            cbbGoiGym.DisplayMember = "TenGoiTap";
            cbbGoiGym.ValueMember = "MaGoiTap";
            cbbGoiSauna.DataSource = goiSaunas;
            cbbGoiSauna.DisplayMember = "TenGoiTap";
            cbbGoiSauna.ValueMember = "MaGoiTap";

            cbbGoiGym.DataSource = goiGyms;
            cbbGoiGym.DisplayMember = "TenGoiTap";
            cbbGoiGym.ValueMember = "MaGoiTap";
            cbbGoiGym.SelectedIndex = cbbGoiSauna.SelectedIndex = 0;
        }

        private void txtMaThe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtHoTen.Focus();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dgrDangKy.SelectedRows.Count > 0)
            {
                FrmHoiVienEdit f = new FrmHoiVienEdit();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    loadData();
                }
            }
            else
            {
                DialogUtils.ShowMessage("Vui lòng chọn một hội viên");
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnDangKy.PerformClick();
            }
        }

        private void cbbGoiGym_SelectedIndexChanged(object sender, EventArgs e)
        {
            tinhTien();
        }

        void tinhTien()
        {
            var g1 = (GoiTap)cbbGoiGym.SelectedItem;
            var g2 = (GoiTap)cbbGoiSauna.SelectedItem;
            if (g1 != null && g2 != null)
            {
                var tienGym = g1.MaGoiTap != -1 ? g1.Gia : 0;
                var tienSauna = g2.MaGoiTap != -1 ? g2.Gia : 0;
                var tongTine = tienGym + tienSauna;
                lblSoTienThanhToan.Text = tongTine.ToString().FormatCurrency();
            }
        }

        private void FrmDangKyNhanh_Load(object sender, EventArgs e)
        {
            tinhTien();
        }

        private void cbbGoiSauna_SelectedIndexChanged(object sender, EventArgs e)
        {
            tinhTien();
        }
    }
}
