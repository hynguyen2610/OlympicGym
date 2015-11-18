using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public class PhieuThu
    {
 
        public int MaPhieuThu { get; set; }
        public DateTime NgayLap { get; set; }
        public int SoTien { get; set; }
        public NhanVien NhanVien { get; set; }
        public HoiVien HoiVien { get; set; }
        public GoiTap GoiTap { get; set; }
        public string LyDo { get; set; }
        public GiamGia GiamGia { get; set; }

        public string TenLoai {
            get {
                return GoiTap.LoaiVe;
            }
        }

        public string MaTheHoiVien {
            get {
                return HoiVien != null ? HoiVien.MaThe : "Khách lẻ";
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
