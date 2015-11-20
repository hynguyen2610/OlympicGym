using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Controller;
using System.IO;
using GymFitnessOlympic.Models.DataFiller;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.View.Utils;
using DevExpress.XtraEditors.Controls;

namespace GymFitnessOlympic.View.Dialog
{
    public partial class FrmNhanVienEdit : BaseDialog
    {
        NhanVien current;
        bool isThem = false;
        bool isHaveFile = false;
        public FrmNhanVienEdit(NhanVien nv = null)
        {
            InitializeComponent();
            imgAnh.Properties.SizeMode = PictureSizeMode.Stretch;
            loadQuyen();
            current = nv;
            if (current != null)
            {
                Text = "Chỉnh sửa nhân viên";
                loadField();
                isThem = false;
                //cbbPhong.Enabled = false;
                txtPassword.Enabled = false;
               
            }
            else
            {
                isThem = true;
                datNgaySinh.Value = new DateTime(1900, 1, 1);
                cbbChucVu.SelectedIndex = 1;
                //cbbChucVu.Enabled = false;
                cbbConLamViec.SelectedIndex = 0;
            }
            cbbPhong.Properties.NullText = "Chọn một phòng tập";
            DataFiller.fillPhongCombo(cbbPhong);
           
        }

        void loadQuyen() {
            List<Quyen> quyens = QuyenController.GetList();
            cbbChucVu.DataSource = quyens;
            cbbChucVu.DisplayMember = "TenQuyen";
            cbbChucVu.ValueMember = "MaQuyen";
            cbbPhong.Properties.NullText = "Vui lòng chọn một phòng";
        }

        private void loadField()
        {
            txtMathe.Text = current.MaThe;
            //txtMathe.Enabled = false;
            txtDiaChi.Text = current.DiaChi;
            txtSoDienThoai.Text = current.SoDienThoai;
            txtTenNhanVien.Text = current.TenNhanVien;
            txtUserName.Text = current.UserName;
            cbbPhong.EditValue = current.PhongTap.MaPhongTap;
            txtSoDienThoai.Text = current.SoDienThoai;
            radNam.Checked = current.GioiTinh;
            datNgaySinh.Value = current.NgaySinh;
            if (current.Anh != null)
            {
                imgAnh.Image = StreamUtil.byteArrayToImage(current.Anh);
            }
            cbbPhong.EditValue = current.PhongTap.MaPhongTap;
            cbbChucVu.SelectedValue = current.Quyen.MaQuyen;
            cbbConLamViec.SelectedIndex = current.IsConLamViec ? 0 : 1;
            btnSave.Text = "Cập nhật";
            Text = "Chỉnh sửa hội viên";
            if (current.GioiTinh)
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtMathe.Text == "") {
                errorProvider1.SetError(txtMathe, "Chưa nhập mã thẻ");
                txtMathe.Focus();
                return;
            }
            if (txtUserName.Text == "") {
                errorProvider1.SetError(txtMathe, "Chưa nhập tên đăng nhập");
                txtUserName.Focus();
                return;
            }

            if (txtTenNhanVien. Text == "")
            {
                errorProvider1.SetError(txtTenNhanVien, "Chưa nhập tên nhân viên");
                txtTenNhanVien.Focus();
                return;
            }
            if (datNgaySinh.Value.Year == 1900)
            {
                errorProvider1.SetError(datNgaySinh, "Ngày sinh không hợp lệ");
                datNgaySinh.Focus();
                return;
            }

             if (current==null && txtPassword.Text == "")
            {
                errorProvider1.SetError(datNgaySinh, "Mật khẩu không được rỗng");
                txtPassword.Focus();
                return;
            }

            if (cbbPhong.GetSelectedDataRow() == null)
            {
                errorProvider1.SetError(cbbPhong, "Chưa chọn phòng");
                cbbPhong.Focus();
                return;
            }

            if (dxValidationProvider1.Validate())
            {
                current = prepareNhanVien();
                if (isThem) 
                {
                    if (NhanVienController.Add(current) == CODE_RESULT_RETURN.ThanhCong)
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
                    if (!NhanVienController.IsTrungMaNvKhac(current))
                    {
                        if (NhanVienController.Update(current) == CODE_RESULT_RETURN.ThanhCong)
                        {
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi cập nhật");
                        }
                    }
                    else {
                        errorProvider1.SetError(txtMathe, "Mã thẻ này đã sử dụng cho nhân viên khác");
                        txtMathe.Focus();
                        return;
                    }
                }
            }
        }

        NhanVien prepareNhanVien()
        {
            if (current == null)
            {
                current = new NhanVien()
                {
                    Password = txtPassword.Text.Trim()
                };
                current.Password = CryptoMd5.MD5Hash(current.Password);
            }
            current.MaThe = txtMathe.Text;
            current.DiaChi = txtDiaChi.Text.Trim();
            current.SoDienThoai = txtSoDienThoai.Text.Trim();
            current.TenNhanVien = txtTenNhanVien.Text.Trim();
            current.UserName = txtUserName.Text.Trim();
            
            current.Quyen = (Quyen)cbbChucVu.SelectedItem;
            current.PhongTap = (PhongTap)cbbPhong.GetSelectedDataRow();
            current.NgaySinh = datNgaySinh.Value;
            current.IsConLamViec = cbbConLamViec.SelectedIndex == 0 ? true : false;
            //current.ngay
            var o = cbbPhong.GetSelectedDataRow();
            if (isHaveFile)
            {
                String fileName = opd.FileName;
                Bitmap bmp = new Bitmap(fileName);
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                byte[] bimage = new byte[fs.Length];
                fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
                fs.Close();

                byte[] Photo = bimage;
                current.Anh = Photo;
            }
            var phong = (PhongTap)cbbPhong.GetSelectedDataRow();
            current.PhongTap = phong;
            return current;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imgAnh_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void imgAnh_MouseClick(object sender, MouseEventArgs e)
        {
            if (opd.ShowDialog() == DialogResult.OK)
            {
                imgAnh.Image = Image.FromFile(opd.FileName);
                isHaveFile = true;
            }
        }
    }
}