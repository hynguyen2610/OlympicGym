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


    }

    
}
