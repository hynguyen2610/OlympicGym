using GymFitnessOlympic.Models.entity;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymFitnessOlympic.Controller
{
    class KhachLeController
    {
        public static CODE_RESULT_RETURN Add(KhachLe k)
        {
            using (var db = DBContext.GetContext())
            {
                try
                {
                    k.NhanVien = db.NhanVien.Find(k.NhanVien.MaNhanVien);
                    if (k.GiamGia != null && k.GiamGia.MaGiamGia != "")
                    {
                        k.GiamGia = db.GiamGia.Find(k.GiamGia.MaGiamGia);
                    }
                    db.KhachLe.Add(k);
                    db.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                catch
                {
                    return CODE_RESULT_RETURN.ThatBai;
                }
            }
        }

        internal static List<KhachLe> ThongKe(DateTime start, DateTime end, Models.NhanVien nhanVienHienTai, int mode)
        {
            using (var db = DBContext.GetContext())
            {
                var ks = db.KhachLe.Include(k => k.NhanVien).Where(k => k.ThoiGian >= start
                    &&
                    k.ThoiGian <= end);
                if (nhanVienHienTai.MaNhanVien != -1)
                {
                    ks = ks.Where(h => h.NhanVien.MaNhanVien == nhanVienHienTai.MaNhanVien);
                }
                switch (mode)
                {
                    case 1:
                        ks = ks.Where(k => k.IsGYM);
                        break;
                    case 2:
                        ks = ks.Where(k => !k.IsGYM);
                        break;
                }
                ks = ks.OrderByDescending(d => d.ThoiGian);
                return ks.ToList();
            }
        }
    }
}
