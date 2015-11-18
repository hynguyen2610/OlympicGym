using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.DataFiller;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.Utils;
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
    public partial class FrmLichSuHoaDon : UserControl
    {
        NhanVien nhanVienHienTai;
        PhongTap phongHienTai;
        List<HoaDon> allHoaDon;
        List<ThongKeSanPhamModel> allThongKe;
        bool IsNhap;

        public FrmLichSuHoaDon(NhanVien _maNV = null, bool isNhap = false)
        {
            InitializeComponent();
            nhanVienHienTai = _maNV;
            dataGridView1.AutoGenerateColumns = false;
            for (int i = 2010; i < 2250; i++)
            {
                cbbTheoThangNam.Items.Add(i);

            }
            IsNhap = isNhap;
            cbbTheoThangNam.SelectedIndex
                = cbbTheoThangThang.SelectedIndex = 0;

            phongHienTai = Login1.GetPhongHienTai();
            // cbbPhong.Properties.NullText = "Chọn một phòng";
            DataFiller.fillPhongCombo(cbbPhong, append:true);
            cbbPhong.SelectedValue = phongHienTai.MaPhongTap;

            //loadData();
            loc();
            loadEnable();
            if (IsNhap)
            {
                lblTitle.Text = "Thống kê nhập hàng";
                pnTongTien.Visible = false;
            }
        }

        void loadEnable()
        {
            cbbPhong.Enabled = nhanVienHienTai == null;
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
                    start =DateTimeUtil.StartOfDay( dtpFrom.Value);
                    end = DateTimeUtil.StartOfDay( dtpTo.Value);
                }
                //List<HoaDon> li = new List<HoaDon>();


                //li = allPhieuThu.Where(h => h.NgayLap.CompareTo(start) >= 0 && h.NgayLap.CompareTo(end) <= 0).ToList();
                allThongKe = SanPhamController.ThongKeMuaVaoBanRa(start, end, maPhong, nhanVienHienTai);
                dataGridView1.DataSource = allThongKe;
                lblTongTien.Text = allThongKe.Sum(c => c.TongTien).ToString().FormatCurrency();
                dataGridView1.Columns[3].Visible = !IsNhap;
            }
            catch { }
        }
    }

    class ThongKeSanPhamModel
    {
        public SanPham SanPham { get; set; }
        public NhanVien NhanVien { get; set; }
        public PhongTap PhongTap { get; set; } 
        public int SoLuong { get; set; }
        public int TongTien { get; set; }

        public string TenNhanVien
        {
            get
            {
                if (NhanVien != null)
                    return NhanVien.TenNhanVien;
                return "Không rõ";
            }
        }

        public string TenPhong {
            get {
                return NhanVien.PhongTap.TenPhongTap;
            }
        }
    }
}
