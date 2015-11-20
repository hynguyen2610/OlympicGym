using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymFitnessOlympic.Controller
{
    class HoaDonController
    {
        internal static List<HoaDon> GetList(int maPhong = -1, NhanVien manv = null)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.HoaDon.Include(n => n.ChiTietHoaDon).Include(h=>h.NhanVien)
                    .Include(h=>h.NhanVien.PhongTap);
                if (maPhong != -1) {
                    nvs = nvs.Where(n => n.NhanVien.PhongTap.MaPhongTap == maPhong);
                }
                if (manv != null) {
                    nvs = nvs.Where(n => n.NhanVien.MaNhanVien == manv.MaNhanVien);
                }
                return nvs.ToList();
            }
        }

        internal static HoaDon GetHoaDoan(int manv)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.HoaDon.Include(h=>h.ChiTietHoaDon).FirstOrDefault(n => n.MaHoaDon == manv);
                return nv;
            }
        }

        internal static CODE_RESULT_RETURN Update(HoaDon hv)
        {
            using (var db = DBContext.GetContext())
            {
                var hvc = db.HoaDon.FirstOrDefault(h => h.MaHoaDon == hv.MaHoaDon);
                if (hvc != null)
                {
                    hvc.NgayLap = hv.NgayLap;
                    hvc.ChiTietHoaDon.Clear();
                    foreach(ChiTietHoaDon c in hv.ChiTietHoaDon){
                        db.ChiTietHoaDon.Add(c);
                    }
                    db.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        internal static CODE_RESULT_RETURN Add(HoaDon hoaDon)
        {
            using (var context = DBContext.GetContext())
            {
                var ds = (from e in context.HoaDon
                          where e.MaHoaDon == hoaDon.MaHoaDon
                          select e).SingleOrDefault();
                if (ds != null)
                    return CODE_RESULT_RETURN.MaTrung;
                else
                {
                    hoaDon.NhanVien = context.NhanVien.Find(hoaDon.NhanVien.MaNhanVien);
                    foreach (var ct in hoaDon.ChiTietHoaDon) {
                        ct.SanPham = context.SanPham.Find(ct.SanPham.MaSanPham);
                        ct.HoaDon = hoaDon;
                    }
                    context.HoaDon.Add(hoaDon);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
            }
        }

        internal static CODE_RESULT_RETURN Delete(int id)
        {
            using (var context = DBContext.GetContext())
            {
                var pt = context.HoaDon.FirstOrDefault(p => p.MaHoaDon == id);
                if (pt != null)
                {
                    context.HoaDon.Remove(pt);
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }

        }

       
    }
}
