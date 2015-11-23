using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Data;

namespace GymFitnessOlympic.Models
{
    public class HistoryNhanVien
    {
        public DateTime ThoiGian { get; set; }
        public bool IsCheckin { get; set; }
        public NhanVien NhanVien { get; set; }
        public CaLamViec Ca { get; set; }

        [NotMapped]
        public int ChenhLech
        {
            get
            {
                var minThoiGian = ThoiGian.Hour * 60 + ThoiGian.Minute;
                var phutBatDau = Ca.GioBatDau.Hours * 60 + Ca.GioBatDau.Minutes;
                var minKetThuc = Ca.GioKetThuc.Hours * 60 + Ca.GioKetThuc.Minutes;

                if (IsCheckin)
                {
                    var d = phutBatDau - minThoiGian;
                    return d > 0 ? 0 : Math.Abs(d);
                }
                var d1 = minKetThuc - minThoiGian;
                return d1 > 0 ? d1 : Math.Abs(d1);
            }
        }
        [NotMapped]
        public String DanhGia
        {
            get
            {
                if (IsCheckin)
                {
                    return ChenhLech >= 0 ? "Trễ" : "Đúng giờ";
                }
                else {
                    return ChenhLech >= 0 ? "Sớm" : "Đúng giờ";
                }
            }
        }

        public string MaTheNhanVien
        {
            get { return NhanVien.MaThe; }
        }

        public string TenNhanVien
        {
            get { return NhanVien.TenNhanVien; }
        }

        public static int TongSoPhutSomTre(List<HistoryNhanVien> danhSachCheckouot, bool isCkeckin)
        {
            if (isCkeckin)
            {
                return danhSachCheckouot.Where(c => c.IsCheckin).Sum(c => c.ChenhLech);
            }
            else
            {
                return danhSachCheckouot.Where(c => !c.IsCheckin
                    ).Sum(c => c.ChenhLech);
            }
        }

        public string TenPhong
        {
            get { return NhanVien.PhongTap.TenPhongTap; }
        }

        public string TenHanhDong
        {
            get { return IsCheckin ? "Checkin" : "Checkout"; }
        }

        public string TenCa
        {
            get { 
                return Ca.TenCa; 
            }
        }

        public string MaThe
        {
            get { 
                return NhanVien.MaThe;
            
            }
        }

        public DateTime Ngay
        {
            get
            {
                return ThoiGian.Date;

            }
        }

        public TimeSpan ThoiGianDung
        {
            get
            {
                return IsCheckin ? Ca.GioBatDau : Ca.GioKetThuc;
            }
        }

        //public string ThoiGianThucTe {
        //    get { 
        //        return ThoiGian.TimeOfDay.ToString("c"); 
        //    }
        //}

        public TimeSpan ThoiGianThucTe
        {
            get
            {
                return ThoiGian.TimeOfDay;
            }
        }

    }
}
