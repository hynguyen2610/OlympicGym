using GymFitnessOlympic.Models.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public class GiamGia
    {
   
        public string MaGiamGia { get; set; }
        public string TenGiamGia { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int PhanTramGiam { get; set; }

        public List<KhachLe> DanhSachKhachLe { get; set; }
        public List<PhieuThu> DanhSachPhieuThu { get; set; }
    }
}
