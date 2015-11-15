using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using GymFitnessOlympic.Models.Util;
namespace GymFitnessOlympic.Models
{
   public  partial class HoiVien
    {
       public string TenPhongTap() {
           return PhongTap.TenPhongTap;
       }

       public int SoNgayTruocSinhNhat {
           get
           {
               return NgaySinh.Date.DayOfYear - DateTime.Now.DayOfYear;
           }
       }

       public override string ToString()
       {
           return TenHoiVien;
       }

       public Image GetAnh {
           get
           {
               return StreamUtil.byteArrayToImage(Anh);
           }
       }
    }
}
