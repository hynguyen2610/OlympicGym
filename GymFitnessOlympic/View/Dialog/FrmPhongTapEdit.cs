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
    public partial class FrmPhongTapEdit : BaseDialog
    {
        PhongTap current;
        public FrmPhongTapEdit(PhongTap p = null)
        {
            InitializeComponent();
            current = p;
            if (current != null)
            {
                btnOK.Text = "Cập nhật";
                Text = "Chỉnh sửa phòng tập";
                txtDiaChi.Text = current.DiaChi;
                txtTenPhong.Text = current.TenPhongTap;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dxErrorProvider1.ClearErrors();
            if (txtTenPhong.Text == "")
            {
                dxErrorProvider1.SetIconAlignment(txtTenPhong, ErrorIconAlignment.MiddleRight);
                dxErrorProvider1.SetError(txtTenPhong, "Tên phòng không được trống");
                txtTenPhong.Focus();
                return;
            }
            if (txtDiaChi.Text == "")
            {
                dxErrorProvider1.SetIconAlignment(txtDiaChi, ErrorIconAlignment.MiddleRight);
                dxErrorProvider1.SetError(txtDiaChi, "Địa chỉ không được trống");
                txtDiaChi.Focus();
                return;
            }
            var tenMoi = txtTenPhong.Text.Trim();
            var dcMoi = txtDiaChi.Text.Trim();
            if (current == null)
            {
                current = new PhongTap()
                {
                    TenPhongTap = tenMoi,
                    DiaChi = dcMoi
                };
                if (PhongTapController.Add(current) == CODE_RESULT_RETURN.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm");
                }
            }
            else
            {

                current.TenPhongTap = tenMoi;
                current.DiaChi = dcMoi;

                if (PhongTapController.Update(current) == CODE_RESULT_RETURN.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Có lỗi khi cập nhật");
                    Close();
                }
            }
        }

        private void txtTenPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                btnOK.PerformClick();
            }
        }




    }
}
