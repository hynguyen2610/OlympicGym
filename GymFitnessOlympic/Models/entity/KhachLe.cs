using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.entity
{
    public class KhachLe
    {
        public DateTime ThoiGian { get; set; }
        public int SoTien { get; set; }
        public NhanVien NhanVien { get; set; }
        public bool IsGYM { get; set; }
        
        public KhachLe()
        {
            IsGYM = true;
        }

        public String LoaiVe {
            get {
                return IsGYM ? "GYM" : "Sauna";
            }
        }
    }
}
