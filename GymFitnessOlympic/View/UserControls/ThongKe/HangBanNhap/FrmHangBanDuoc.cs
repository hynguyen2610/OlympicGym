using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.DataFiller;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.Utils;
using GymFitnessOlympic.View.UserControls.ThongKe.HangBanNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.ActForm.ThongKe
{
    public partial class FrmHangBanDuoc : UserControl
    {
        NhanVien nhanVienHienTai;
        PhongTap phongHienTai;
        List<ThongKeSanPhamModel> allThongKe;
        bool IsNhap;

        public FrmHangBanDuoc(NhanVien nhanVien = null, bool isNhap = false)
        {
            InitializeComponent();
            nhanVienHienTai = nhanVien;


            for (int i = 2010; i < 2250; i++)
            {
                cbbTheoThangNam.Items.Add(i);

            }
            IsNhap = isNhap;
            cbbTheoThangNam.SelectedIndex
                = cbbTheoThangThang.SelectedIndex = 0;

            phongHienTai = Login1.GetPhongHienTai();
            DataFiller.fillNhanVienCombo(cbbNhanVien, phongHienTai.MaPhongTap, append: true);
            DataFiller.fillPhongCombo(cbbPhong, append: true);
            cbbPhong.SelectedValue = phongHienTai.MaPhongTap;
            cbbPhong.Enabled = cbbNhanVien.Enabled = nhanVien == null;
            //loadData();
            loc();

            if (IsNhap)
            {
                lblTitle.Text = "Thống kê nhập hàng";
                pnTongTien.Visible = false;
            }
            if (nhanVien != null)
            {
                cbbNhanVien.Enabled = false;
                cbbNhanVien.SelectedValue = nhanVien.MaNhanVien;
            }
        }



        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbbPhong.SelectedItem == null)
            {
                cbbPhong.Focus();
                dxErrorProvider1.SetError(cbbPhong, "Chưa chọn phòng");
                return;
            }
            loc();
        }

        void loc()
        {
            //var maPhong =Convert.ToInt32( cbbPhong.SelectedItem);
            try
            {
                phongHienTai = (PhongTap)cbbPhong.SelectedItem;
            }
            catch
            {
            }
            var maPhong = phongHienTai != null ? phongHienTai.MaPhongTap : -1;
            //allHoaDon = HoaDonController.GetList(phongHienTai.MaPhongTap, nhanVienHienTai);
            try
            {
                DateTime start = new DateTime(), end = new DateTime();
                if (rdTheoThang.Checked)
                {
                    int month = int.Parse(cbbTheoThangThang.Text.ToString());
                    int year = int.Parse(cbbTheoThangNam.Text.ToString());
                    start = new DateTime(year, month, 1);
                    end = start.AddMonths(1).AddDays(-1);
                }

                else if (rdTheoKhoangNgay.Checked)
                {
                    start = DateTimeUtil.StartOfDay(dtpFrom.Value);
                    end = DateTimeUtil.EndOfDay(dtpTo.Value);
                }
                //List<HoaDon> li = new List<HoaDon>();


                //li = allPhieuThu.Where(h => h.NgayLap.CompareTo(start) >= 0 && h.NgayLap.CompareTo(end) <= 0).ToList();
                allThongKe = SanPhamController.ThongKeMuaVaoBanRa(start, end, maPhong, nhanVienHienTai, IsNhap);
                lblTongTien.Text = allThongKe.Sum(c => c.TongTien).ToString().FormatCurrency();
                pnGrid.Controls.Clear();
                if (IsNhap)
                {
                    var grid = new UcGridHangNhap();

                    pnGrid.Controls.Add(grid);
                    grid.dataGridView1.DataSource = allThongKe;
                }
                else
                {
                    var grid = new UcGridHangBan();
                    pnGrid.Controls.Add(grid);
                    grid.dataGridView1.DataSource = allThongKe;
                }
            }
            catch { }
        }

        private void cbbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            nhanVienHienTai = (NhanVien)cbbNhanVien.SelectedItem;
        }
    }

    class ThongKeSanPhamModel
    {
        public SanPham SanPham { get; set; }
        public NhanVien NhanVien { get; set; }
        public PhongTap PhongTap { get; set; }
        public int SoLuong { get; set; }
        public int TongTien { get; set; }
        public DateTime NgayNhap
        {
            get;
            set;
        }

        public string TenNhanVien
        {
            get
            {
                if (NhanVien != null)
                    return NhanVien.TenNhanVien;
                return "Không rõ";
            }
        }

        public string TenPhong
        {
            get
            {
                return NhanVien.PhongTap.TenPhongTap;
            }
        }
    }
}
