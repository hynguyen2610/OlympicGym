using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NhaHang.Code.Helper.BanHang;
using TapHoaCode.GUI.Form1.BanHang;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Utils;
using GymFitnessOlympic.View.Utils;

namespace TanHongPhat
{
    public partial class FrmBanHang : UserControl
    {
        List<SanPham> allSanPham;
        public HoaDon hoaDon;
        bool isNhap;
        SanPham hangHienTai;

        public FrmBanHang(bool isNhap = false)
        {
            InitializeComponent();
            lblTongTien.Visible = !isNhap;
            int phongID = Login1.GetPhongHienTai().MaPhongTap;
            allSanPham = SanPhamController.GetList(phongID);
            lbSanPham.DisplayMember = "ListBoxString";
            hoaDon = new HoaDon();
            this.isNhap = isNhap;
            lblTitle.Text = isNhap ? "Nhập hàng" : "Bán hàng";
            if (isNhap) {
                btnReset.Text = "Hủy phiếu nhập hiện tại";
                btnSave.Text = "Nhập hàng";
            }
            txtMaVach.Focus();
        }

        void loadListSanPham(List<SanPham> li)
        {

            lbSanPham.DataSource = li;
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            hoaDon = new HoaDon();
            loadListSanPham(allSanPham);
        }

      


        private void txtTenHangTim_EditValueChanged(object sender, EventArgs e)
        {
            //var st = txtTenHangTim.Text.Trim();
            //var li = allSanPham.Where(s => s.TenSanPham.ToUpper().Contains(st.ToUpper())).ToList();
            //loadListSanPham(li);
        }


     

        private void cbbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData() { }

        private void lbHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void chuanBiThemSanPham(SanPham h) {
            txtMaVach.Text = h.MaVachSanPham.ToString();
            txtTenHang.Text = h.TenSanPham;
            txtDonGia.Text = h.Gia.ToString();
            spnSoLuong.Value = 1 ;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int soLuong = 0,  gia = 0;
            if (txtDonGia.Text == "" || !int.TryParse(txtDonGia.Text, out gia)) {
                ep.SetError(txtDonGia, "Đơn giá chưa nhập hoặc không hợp lệ");
                txtDonGia.Focus();
                return;
            }
            if (gia < 0) {
                ep.SetError(txtDonGia, "Đơn giá phải là số nguyên dương");
                txtDonGia.Focus();
                return;
            }
            if (spnSoLuong.Value <= 0) {
                ep.SetError(spnSoLuong, "Số lượng phải là số nguyên dương");
                spnSoLuong.Focus();
                return;
            }
            soLuong = Convert.ToInt32( spnSoLuong.Value);
            //var h = (SanPham)lbSanPham.SelectedItem;
            //if (!isNhap)
            //{
            //    var r = HelperBanHang.themVaoPhieuNhap(this, hangHienTai);
            //}
            //else { 
                
            //}
            //if (r == 0)
            //{
            //    HelperBanHang.tangSoLuong(hoaDon, hangHienTai, Convert.ToInt32(spnSoLuong.Value));
            //}
            ChiTietHoaDon ct = new ChiTietHoaDon() { 
                SanPham = hangHienTai,
                SoLuong = soLuong,
                Gia = gia
            };
            //if (isNhap) {
                var c1 = hoaDon.ChiTietHoaDon.FirstOrDefault(c => c.SanPham.MaSanPham == hangHienTai.MaSanPham);
                if (c1 == null)
                {
                    hoaDon.ChiTietHoaDon.Add(ct);
                }
                else {
                    c1.SoLuong += soLuong;
                }
            //}
            updateGridHoaDon();
            capNhatLabelTien();

        }



        private void updateGridHoaDon()
        {
            var pn = hoaDon;
            lvHangNhap.Items.Clear();
            foreach (ChiTietHoaDon c in pn.ChiTietHoaDon)
            {
                string[] s = { c.SanPham.MaSanPham.ToString(), c.SanPham.TenSanPham, c.SoLuong.ToString(), c.Gia.ToString(), (c.SoLuong * c.Gia).ToString() };
                ListViewItem i = new ListViewItem(s);
                lvHangNhap.Items.Add(i);
            }
        }

        private void capNhatLabelTien()
        {
            lblTongTien.Text = hoaDon.ChiTietHoaDon.Sum(c => c.SoLuong * c.Gia).ToString().FormatCurrency() + "đ";

        }

        private void btnChiTietSua_Click(object sender, EventArgs e)
        {
            if (lvHangNhap.SelectedItems[0] != null)
            {
                var mh = Convert.ToInt32(lvHangNhap.SelectedItems[0].SubItems[0].Text);
                var c = hoaDon.ChiTietHoaDon.FirstOrDefault(c1 => c1.MaSanPham == mh);
                FrmChiTietEdit f = new FrmChiTietEdit(c);
                f.Show();
                f.FormClosed += finishEdit;
            }
            else {
                MessageBox.Show("Chưa chọn mục để sửa");
            }
        }

        void finishEdit(object sender, FormClosedEventArgs e)
        {
            updateForm();
        }

        void updateForm()
        {
            updateGridHoaDon();
            capNhatLabelTien();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            hoaDon = new HoaDon();
            lvHangNhap.Items.Clear();
            capNhatLabelTien();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChiTietXoa_Click(object sender, EventArgs e)
        {
            if (lvHangNhap.SelectedItems.Count > 0)
            {
                var mh = int.Parse(lvHangNhap.SelectedItems[0].SubItems[0].Text);
                var c = hoaDon.ChiTietHoaDon.FirstOrDefault(c1 => c1.SanPham.MaSanPham == mh);
                if (c != null)
                {
                    hoaDon.ChiTietHoaDon.Remove(c);
                }
                updateForm();
            }
            else {
                MessageBox.Show("Chưa chọn mục để xóa");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        

      

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lvHangNhap_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            var sp = (SanPham) lbSanPham.Items[e.ItemIndex];
             
        }

        private void lbSanPham_MeasureItem(object sender, MeasureItemEventArgs e)
        {
           
        }

        private void lbSanPham_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!isNhap)
            {
                var ct = hoaDon.ChiTietHoaDon.FirstOrDefault(c => c.SoLuong > c.SanPham.SoLuongHienTai);
                if (ct != null)
                {
                    MessageBox.Show("Mặt hàng " + ct.SanPham.TenSanPham + " có số lượng bán ra yêu cầu lớn hơn số lượng hiện có");
                    return;
                }
            }
            if (hoaDon.ChiTietHoaDon.Count > 0)
            {
                //hoaDon.ThoiGianTao = DateTime.Now;
                var nhanVien = Login1.TaiKhoanHienTai;

                string message = isNhap ? "phiếu nhập" : "hóa đơn";
                hoaDon.IsNhap = isNhap;
                hoaDon.NgayLap = DateTime.Now;
                hoaDon.NhanVien = nhanVien;                

                if (HoaDonController.Add(hoaDon) == CODE_RESULT_RETURN.ThanhCong)
                {
                    DialogUtils.ShowMessage("Đã tạo "+message);
                }
                else {
                    DialogUtils.ShowMessage("Có lỗi khi tạo "+message);
                }

                btnReset.PerformClick();
                return;
            }

            else
            {
                MessageBox.Show("Chưa có mặt hàng nào trong " + (isNhap ? "phiếu nhập" : "hóa đơn"));
            }
        }

        private void btnQuet_Click(object sender, EventArgs e)
        {
            lblThongBao.Visible = false;
            if (txtTimKiem.Text == "") {
                ep.SetError(txtTimKiem, "Mã hàng không được trống");
                txtTimKiem.Focus();
                return;
            }
            var ma = txtTimKiem.Text.Trim();
            hangHienTai = SanPhamController.GetByMa(ma);
            if (hangHienTai != null)
            {
                chuanBiThemSanPham(hangHienTai);
                lblThongBao.Text = "Tìm thấy mặt hàng";
            }
            else {
                lblThongBao.Text = "Không tìm thấy mặt hàng có mã này";
            }
            lblThongBao.Visible = true;
        }

        private void txtTenHangTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                btnQuet.PerformClick();
            }
        }

        private void lbSanPham_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbSanPham.SelectedItem != null)
            {
                hangHienTai = (SanPham)lbSanPham.SelectedItem;
                chuanBiThemSanPham(hangHienTai);
            }
        }
    }
}