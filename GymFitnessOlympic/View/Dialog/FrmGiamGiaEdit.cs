using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.View.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.Dialog
{
    public partial class FrmGiamGiaEdit : BaseDialog
    {
        public GiamGia ct;
        public FrmGiamGiaEdit(GiamGia c = null)
        {
            InitializeComponent();
            ct = c;
            //txtTenGiamGia.Text = ct.TenGiamGia;
            //dtpNgayBatDau.Value = c.NgayBatDau;
            //dtpNgayKetThuc.Value = c.NgayKetThuc;
            if (ct != null)
            {
                txtMaGiamGia.Enabled = false;
                txtTenGiamGia.Text = ct.TenGiamGia;
                dtpNgayBatDau.Value = ct.NgayBatDau;
                dtpNgayKetThuc.Value = ct.NgayKetThuc;
                txtMaGiamGia.Text = ct.MaGiamGia;
                txtMaGiamGia.Enabled = false;
                txtPhanTram.Text = ct.PhanTramGiam.ToString();
                if (ct.NgayKetThuc.Date < DateTime.Now.Date)
                    btnCapNhat.Enabled = false;
            }
            else
            {
                dtpNgayBatDau.Value = dtpNgayKetThuc.Value = new DateTime(1900, 1, 1);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
         
#region validate
                if (txtMaGiamGia.Text == "")
                {
                    errorProvider1.SetError(txtMaGiamGia, "Chưa nhập mã giảm giá");
                    txtMaGiamGia.Focus();
                    return;
                }

                if (txtTenGiamGia.Text == "")
                {
                    errorProvider1.SetError(txtTenGiamGia, "Chưa nhập tên giảm giá");
                    txtTenGiamGia.Focus();
                    return;
                }
                DateTime ngayBatDau = dtpNgayBatDau.Value, ngayKetThuc = dtpNgayKetThuc.Value;

                if (ngayBatDau.Year == 1900)
                {
                    errorProvider1.SetError(dtpNgayBatDau, "Ngày bắt đầu không hợp lệ");
                    dtpNgayBatDau.Focus();
                    return;
                }
                if (ngayKetThuc.Year == 1900)
                {
                    errorProvider1.SetError(dtpNgayKetThuc, "Ngày kết thúc không hợp lệ");
                    dtpNgayKetThuc.Focus();
                    return;
                }

                if (ngayKetThuc.Date < ngayBatDau.Date)
                {
                    errorProvider1.SetError(dtpNgayKetThuc, "Ngày kết thúc không được sớm hơn ngày bắt đầu");
                    dtpNgayKetThuc.Focus();
                    return;
                }
                if (ct == null)
                {
                    if (ngayBatDau.Date < DateTime.Now.Date)
                    {
                        errorProvider1.SetError(dtpNgayBatDau, "Ngày bắt đầu không được sớm hơn ngày hiện tại");
                        dtpNgayBatDau.Focus();
                        return;
                    }
                }
                else
                    if (ngayKetThuc.Date < DateTime.Now.Date)
                    {
                        errorProvider1.SetError(dtpNgayKetThuc, "Ngày kết thúc không được nhỏ hơn ngày hiện tại");
                        dtpNgayKetThuc.Focus();
                        return;
                    }

                if (txtPhanTram.Text == "")
                {
                    errorProvider1.SetError(txtPhanTram, "Chưa nhập phần trăm giảm giá");
                    txtPhanTram.Focus();
                    return;
                }
                int phanTram;
                if (!int.TryParse(txtPhanTram.Text, out phanTram) ||  phanTram <0 || phanTram > 100)
                {
                    errorProvider1.SetError(txtPhanTram, "Mã giảm giá phải là số từ 0 đến 100");
                    txtPhanTram.Focus();
                    return;
                }
                #endregion validate
            try{
                if (ct == null)
                {
                    var gg = new GiamGia()
                    {
                        MaGiamGia = txtMaGiamGia.Text.Trim(),
                        NgayBatDau = dtpNgayBatDau.Value,
                        NgayKetThuc = dtpNgayKetThuc.Value,
                        PhanTramGiam = phanTram,
                        TenGiamGia = txtTenGiamGia.Text.Trim()
                    };
                    var r = GiamGiaController.Add(gg);
                    switch (r)
                    {
                        case CODE_RESULT_RETURN.MaTrung:
                            errorProvider1.SetError(txtMaGiamGia, "Mã giảm giá này đã tồn tại");
                            txtMaGiamGia.Focus();
                            return;
                        case CODE_RESULT_RETURN.ThanhCong:
                            DialogResult = DialogResult.OK;
                            break;
                        case CODE_RESULT_RETURN.ThatBai:
                            DialogUtils.ShowError("Có lỗi khi tạo giảm giá");
                            return;
                    }
                }
                else
                {
                    //ct.MaGiamGia = txtMaGiamGia.Text.Trim();
                    ct.NgayBatDau = dtpNgayBatDau.Value;
                    ct.NgayKetThuc = dtpNgayKetThuc.Value;
                    ct.PhanTramGiam = phanTram;
                    ct.TenGiamGia = txtTenGiamGia.Text.Trim();
                    var r = GiamGiaController.Update(ct);
                    switch (r)
                    {
                       
                        case CODE_RESULT_RETURN.ThanhCong:
                            DialogResult = DialogResult.OK;
                            break;
                        case CODE_RESULT_RETURN.ThatBai:
                            DialogUtils.ShowError("Có lỗi khi cập nhật giảm giá");
                            return;
                    }
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra dữ liệu nhập vào");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
