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
        public string TenGiamGia { get; set; }
       // public int TienGoi;
        public int PhanTramGiam{get;set;}


        public int TienSauGiam { 
            get {
                return SoTien - SoTien * PhanTramGiam / 100;
            } 
        }

        public string TenLoai {
            get {
                return GoiTap.LoaiVe;
            }
        }

        public string MaTheHoiVien {
            get {
                return HoiVien != null ? HoiVien.MaThe : "Không có";
            }
        }

        public string TenHoiVien
        {
            get
            {
                return HoiVien != null ? HoiVien.TenHoiVien : "Khách lẻ";
            }
        }

        public string TenPhong
        {
            get
            {
                return NhanVien.PhongTap.TenPhongTap;
            }
        }

        //public int TienPhaiTraDangKy {
        //    get {
        //        return GiamGia != null ?  GoiTap.Gia - GoiTap.Gia * GiamGia.PhanTramGiam / 100 : GoiTap.Gia;
        //    }
        //}

        public string TenGoi
        {
            get {
                return GoiTap.TenGoiTap;
            }
        }



       
        //public in SoTienGoi
        //{
        //    get
        //    {
        //        return GoiTap.Gia.ToString();
        //    }
        //}



    }
}
