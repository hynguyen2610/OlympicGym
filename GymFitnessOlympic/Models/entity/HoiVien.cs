using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public partial class HoiVien
    {
        public int MaHoiVien { get; set; }
        public string MaThe { get; set; }
        public string TenHoiVien { get; set; }
        //public string MaSauna { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgayHetHanGYM { get; set; }
        public DateTime NgayHetHanSauNa { get; set; }
        public DateTime GiaHanCuoiGYM { get; set; }
        public DateTime GiaHanCuoiSauna { get; set; }
        public PhongTap PhongTap { get; set; }
       public int MaPhongTap { get; set; }
        public byte[] Anh { get; set; }
        public List<PhieuThu> DanhSachPhieuThu { get; set; }
        public List<HistoryHoiVien> LichSu { get; set; }
        public DateTime NgayGioDangKy { get; set; }
        public bool IsDangKyNhanh { get; set; }
        public HoiVien()
        {
            NgayHetHanGYM = NgayHetHanSauNa = GiaHanCuoiGYM = GiaHanCuoiSauna = DateTime.Now;
            NgayGioDangKy = DateTime.Now;
            IsDangKyNhanh = false;
        }

        public String DaCapNhatString {
            get {
                return IsDangKyNhanh ? "Chưa cập nhật" : "Đã cập nhật";
            }
        }
    }
}
