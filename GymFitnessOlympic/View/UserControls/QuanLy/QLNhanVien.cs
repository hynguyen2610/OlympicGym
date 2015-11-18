using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.View.Dialog;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.View.Systems;
using GymFitnessOlympic.View.Utils;
using GymFitnessOlympic.Properties;

namespace GymFitnessOlympic.View.UserControls
{
    public partial class QLNhanVien : UserControl
    {
        List<NhanVien> all;

        public QLNhanVien()
        {
            InitializeComponent();
            dgrNhanVien.AutoGenerateColumns = false;
            cbbBiKhoa.SelectedIndex = 0;
            cbbConLamViec.SelectedIndex = 0;
            loadData();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgrNhanVien.SelectedRows.Count > 0)
            {
                var nv = (NhanVien)dgrNhanVien.SelectedRows[0].DataBoundItem;
                if (!NhanVienController.IsKhongRangBuoc(nv))
                {
                    MessageBox.Show("Không thể xóa do còn dữ liệu liên quan");
                    return;
                }
                if (DialogUtils.Confirmed("Bạn có thực sự muốn xóa") != true)
                {
                    return;
                }
                if (nv.MaNhanVien == Login1.TaiKhoanHienTai.MaNhanVien)
                {
                    MessageBox.Show("Tài khoản này hiện đang đăng nhập, không thể xóa");
                    return;
                }
                if (NhanVienController.Delete(nv.MaNhanVien) == CODE_RESULT_RETURN.ThanhCong)
                {
                    loadData();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa");
                }
            }
            else
            {
                MessageBox.Show("Chọn nhân viên để xóa");
            }
        }



        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dgrNhanVien.SelectedRows.Count > 0)
            {
                NhanVien v = (NhanVien)dgrNhanVien.SelectedRows[0].DataBoundItem;
                FrmNhanVienEdit edit = new FrmNhanVienEdit(v);
                edit.ShowDialog();
                if (edit.DialogResult == DialogResult.OK)
                {
                    loadData();
                }
            }
        }

        void loadData()
        {
            int biKhoa = cbbBiKhoa.SelectedIndex;
            int clv = cbbConLamViec.SelectedIndex;

            all = NhanVienController.GetList(biKhoa, clv, Login1.GetPhongHienTai().MaPhongTap);
            updateTable(all);
            //gridControl1.DataSource = all;
        }

        void updateTable(List<NhanVien> li)
        {
            dgrNhanVien.DataSource = li;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FrmNhanVienEdit edit = new FrmNhanVienEdit();
            if (edit.ShowDialog() == DialogResult.OK)
            {
                loadData();
            }
        }



        private void dgrNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrNhanVien.SelectedRows.Count > 0)
            {
                var a = (NhanVien)dgrNhanVien.SelectedRows[0].DataBoundItem;
                if (a.Anh != null)
                {
                    imgAnh.Image = StreamUtil.byteArrayToImage(a.Anh);

                }
                else
                {
                    imgAnh.Image = null;
                }
                btnKhoa.Text = a.IsKhoa ? "Mở khóa" : "Khóa";
                btnKhoa.Image = a.IsKhoa ? Resources.lock_open : Resources.lock_lock;
                updateButton();
            }

        }


        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (dgrNhanVien.SelectedRows.Count > 0)
            {
                var r = DialogUtils.ConfirmedWithTitle("Xác nhận reset mật khẩu", "Bạn có chắc chắn reset mật khẩu về mặc định là 12345 không?");
                if (r != true)
                    return;
                var nv = (NhanVien) dgrNhanVien.SelectedRows[0].DataBoundItem;
                nv.Password = CryptoMd5.MD5Hash("12345");
                if (NhanVienController.Update(nv) == CODE_RESULT_RETURN.ThanhCong)
                {
                    MessageBox.Show("Reset thành công, password hiện tại là 12345");
                }
                else {
                    DialogUtils.ShowMessage("Có lỗi khi đổi mật khẩu");
                }
                //FormChangePassword f = new FormChangePassword(Login1.GetTaiKhoanHienTai());
                //f.ShowDialog();
            }
            else {
                DialogUtils.ShowMessage("Chưa chọn nhân viên");
            }
        }

        private void dgrNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cbbConLamViec_SelectedIndexChanged(object sender, EventArgs e)
        {

            loadData();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            if (dgrNhanVien.SelectedRows.Count > 0)
            {
                var nv = (NhanVien)dgrNhanVien.SelectedRows[0].DataBoundItem;
                nv.IsKhoa = !nv.IsKhoa;
                if (NhanVienController.Update(nv) == CODE_RESULT_RETURN.ThanhCong)
                {

                    loadData();
                    // dgrNhanVien.s

                }
            }
            else
            {
                DialogUtils.ShowMessage("Chưa chọn nhân viên");
            }
        }

        void updateButton()
        {
            NhanVien nv = (NhanVien)dgrNhanVien.SelectedRows[0].DataBoundItem;
            var locked = Resources.lock_lock;
            var opened = Resources.lock_open;
            btnKhoa.Image = (nv.IsKhoa) ? opened : locked;
            btnKhoa.Text = (nv.IsKhoa) ? "Mở khóa" : "Khóa";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



    }

    public enum Khoa
    {
        KhongKhoa,
        DaKhoa

    }

    public enum ConLamViec
    {
        ConLamViec,
        DaNghi
    }
}
