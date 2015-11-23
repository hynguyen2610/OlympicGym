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
using GymFitnessOlympic.Models.DataFiller;

namespace GymFitnessOlympic.View.UserControls.ThongKe
{
    public partial class FrmDangKyNhanh : UserControl
    {
        int tienGym, tienSauna;

        public FrmDangKyNhanh()
        {
            InitializeComponent();
            dgrDangKy.AutoGenerateColumns = false;
            loadCombo();
            loadData();
            DataFiller.fillGiamGiaCombo(cbbGiamGiaGYM, true, true);
            DataFiller.fillGiamGiaCombo(cbbGiamGiaSauna, true, true);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lblThanhCong.Visible = false;
            #region validate
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
            #endregion validate
            var hv = new HoiVien()
            {
                TenHoiVien = txtHoTen.Text.Trim(),
                MaThe = txtMaThe.Text.Trim(),
                PhongTap = Login1.GetPhongHienTai(),
                NgayGioDangKy = DateTime.Now,
                NgaySinh = new DateTime(1900, 1, 1),
                IsDangKyNhanh = true,

            };
            var r = HoiVienController.Add(hv);
            if (r == CODE_RESULT_RETURN.ThatBai)
            {
                DialogUtils.ShowError("Có lỗi khi tạo hội viên");
                return;
            }
            if (r == CODE_RESULT_RETURN.MaTrung)
            {
                errorProvider1.SetError(txtMaThe, "Mã thẻ này đã tồn tại trong hệ thống");
                txtMaThe.Focus();
                return;
            }
            if (g1.MaGoiTap != -1)
            {
                PhieuThu pt = new PhieuThu()
                {
                    GoiTap = g1,
                    HoiVien = hv,
                    NgayLap = DateTime.Now,
                    NhanVien = Login1.TaiKhoanHienTai,
                    SoTien = tienGym
                };

                if (cbbGiamGiaGYM.SelectedValue.ToString() != "")
                {
                    pt.GiamGia = (GiamGia)cbbGiamGiaGYM.SelectedItem;
                }
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
                    SoTien = tienSauna
                };
                if (cbbGiamGiaSauna.SelectedValue.ToString() != "")
                {
                    pt.GiamGia = (GiamGia)cbbGiamGiaSauna.SelectedItem;
                }
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
            lblTongTienTrongNgay.Text = HoiVienController.TongTienDknTrongNgay().ToString().FormatCurrency();

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
                var hv = (HoiVien)dgrDangKy.SelectedRows[0].DataBoundItem;
                FrmHoiVienEdit f = new FrmHoiVienEdit(hv);
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
                tienGym = g1.MaGoiTap != -1 ? g1.Gia : 0;
                tienSauna = g2.MaGoiTap != -1 ? g2.Gia : 0;
                //Neu co giam gia
                int giamGym = 0, giamSauna = 0;
                if (cbbGiamGiaGYM.SelectedItem != null)
                {
                    var gGym = (GiamGia)cbbGiamGiaGYM.SelectedItem;
                    giamGym = gGym.PhanTramGiam * tienGym / 100;
                }
                if (cbbGiamGiaSauna.SelectedItem != null)
                {
                    var gSau = (GiamGia)cbbGiamGiaSauna.SelectedItem;
                    giamSauna = gSau.PhanTramGiam * tienSauna / 100;
                }
                //

                tienGym = tienGym - giamGym;
                tienSauna = tienSauna - giamSauna;

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

        private void btnInGym_Click(object sender, EventArgs e)
        {
            inPhieu(true);
        }

        void inPhieu(bool isGYM)
        {
            if (dgrDangKy.SelectedRows.Count > 0)
            {
                var hv = (HoiVien)dgrDangKy.SelectedRows[0].DataBoundItem;
                if (isGYM && hv.NgayHetHanGYM.Date <= DateTime.Now.Date) {
                    DialogUtils.ShowMessage("Thẻ này đã hết hạn GYM");
                    return;
                }
                else if (!isGYM && hv.NgayHetHanSauNa.Date <= DateTime.Now.Date)
                {
                    DialogUtils.ShowMessage("Thẻ này đã hết hạn Sauna");
                    return;
                }
                FrmInPhieu f = new FrmInPhieu(hv, isGYM);
                //f.ShowDialog();
            }
        }

        private void btnInSauna_Click(object sender, EventArgs e)
        {
            inPhieu(false);
        }
    }
}
