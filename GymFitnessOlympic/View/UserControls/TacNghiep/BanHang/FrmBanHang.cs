﻿using System;
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

namespace TanHongPhat
{
    public partial class FrmBanHang : UserControl
    {
        List<SanPham> allSanPham;
        public HoaDon hoaDon;
        bool isNhap;

        public FrmBanHang(bool isNhap = false)
        {
            InitializeComponent();
            int phongID = Login1.GetPhongHienTai().MaPhongTap;
            allSanPham = SanPhamController.GetList(phongID);
            lbSanPham.DisplayMember = "ListBoxString";
            hoaDon = new HoaDon();
            this.isNhap = isNhap;
            if (isNhap) {
                btnReset.Text = "Hủy phiếu nhập hiện tại";
                btnSave.Text = "Nhập hàng";
            }
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
            var st = txtTenHangTim.Text.Trim();
            var li = allSanPham.Where(s => s.TenSanPham.ToUpper().Contains(st.ToUpper())).ToList();
            loadListSanPham(li);
        }


     

        private void cbbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData() { }

        private void lbHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSanPham.SelectedItem != null)
            {
                var h = (SanPham)lbSanPham.SelectedItem;
                txtMaHang.Text = h.MaSanPham.ToString();
                txtTenHang.Text = h.TenSanPham;
                txtDonGia.Text = h.Gia.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var h = (SanPham)lbSanPham.SelectedItem;
            var r = HelperBanHang.themVaoPhieuNhap(this, h);
            if (r == 0)
            {
                HelperBanHang.tangSoLuong(hoaDon, h, Convert.ToInt32(spnSoLuong.Value));
            }
          
            updateGridHoaDon();
            capNhatLabelTien();

        }

        private void updateGridHoaDon()
        {
            var pn = hoaDon;
            lvHangNhap.Items.Clear();
            foreach (ChiTietHoaDon c in pn.DanhSachChiTiet)
            {
                string[] s = { c.SanPham.MaSanPham.ToString(), c.SanPham.TenSanPham, c.SoLuong.ToString(), c.Gia.ToString(), (c.SoLuong * c.Gia).ToString() };
                ListViewItem i = new ListViewItem(s);
                lvHangNhap.Items.Add(i);
            }
        }

        private void capNhatLabelTien()
        {
            lblTongTien.Text = hoaDon.DanhSachChiTiet.Sum(c => c.SoLuong * c.Gia).ToString();

        }

        private void btnChiTietSua_Click(object sender, EventArgs e)
        {
            if (lvHangNhap.SelectedItems[0] != null)
            {
                var mh = Convert.ToInt32(lvHangNhap.SelectedItems[0].SubItems[0].Text);
                var c = hoaDon.DanhSachChiTiet.FirstOrDefault(c1 => c1.MaSanPham == mh);
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
            if (!isNhap)
            {
                var ct = hoaDon.DanhSachChiTiet.FirstOrDefault(c => c.SoLuong > c.SanPham.SoLuongHienTai);
                if (ct != null)
                {
                    MessageBox.Show("Mặt hàng " + ct.SanPham.TenSanPham + " có số lượng bán ra yêu cầu lớn hơn số lượng hiện có");
                    return;
                }
            }
            if (hoaDon.DanhSachChiTiet.Count > 0)
            {
                //hoaDon.ThoiGianTao = DateTime.Now;
                var nhanVien = Login1.TaiKhoanHienTai;

                string message = isNhap ? "Đã tạo phiếu nhập" : "Đã tạo hóa đơn";
                hoaDon.IsNhap = isNhap;
                hoaDon.NgayLap = dtpThoiGian.Value;
                HelperBanHang.taoHoaDonTamThoi(hoaDon, nhanVien, message);
                btnReset_Click(null, null);
                return;
            }
            
            else {
                MessageBox.Show("Chưa có mặt hàng nào trong "+ (isNhap ? "phiếu nhập" : "hóa đơn"));
            }
        }

        private void btnChiTietXoa_Click(object sender, EventArgs e)
        {
            if (lvHangNhap.SelectedItems.Count > 0)
            {
                var mh = int.Parse(lvHangNhap.SelectedItems[0].SubItems[0].Text);
                var c = hoaDon.DanhSachChiTiet.FirstOrDefault(c1 => c1.SanPham.MaSanPham == mh);
                if (c != null)
                {
                    hoaDon.DanhSachChiTiet.Remove(c);
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
    }
}