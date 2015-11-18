using GymFitnessOlympic.Models.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public class HistoryHoiVien
    {
        public DateTime ThoiGian { get; set; }
        //public bool IsSauna {get;set;}
        public HoiVien HoiVien { get; set; }
        public bool IsDaInGYM { get; set; }
        public bool IsDaInSauna { get; set; }

        public HistoryHoiVien() {
            IsDaInGYM = IsDaInSauna = false;
        }

        public String TenHoiVien {
            get {
                return HoiVien.TenHoiVien;
            }
        }

        public string DaInGYM {
            get {
                return IsDaInGYM ? "Đã in" : "Chưa in"; 
            }
        }

        public string DaInSauna
        {
            get
            {
                return IsDaInSauna ? "Đã in" : "Chưa in";
            }
        }

        public string NgayHetHanGYM
        {
            get {
                return DateTimeUtil.dateToString(HoiVien.NgayHetHanGYM);
            }
        }

        public string NgayHetHanSauna
        {
            get
            {
                return DateTimeUtil.dateToString(HoiVien.NgayHetHanSauNa);
            }
        }

        public string MaThe{
            get {
                return HoiVien.MaThe;
            }
        }

        public string TenPhong
        {
            get {
                return HoiVien.PhongTap.TenPhongTap;
            }
        }

     



    }

    
}
