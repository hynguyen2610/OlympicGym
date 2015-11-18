using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymFitnessOlympic.Controller
{
    class GiamGiaController
    {
        internal static List<GiamGia> GetList(bool chuaNgayHienTai = false)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.GiamGia;
                if (chuaNgayHienTai)
                {
                    return nvs.Where(g => g.NgayBatDau < DateTime.Now && g.NgayKetThuc > DateTime.Now)
                       .OrderByDescending(c=>c.NgayKetThuc) .ToList();
                }
                return nvs.ToList();
            }
        }

        internal static GiamGia GetByID(string maSP)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.GiamGia.FirstOrDefault(n => n.MaGiamGia == maSP);
                return nv;
            }
        }


        internal static CODE_RESULT_RETURN Add(GiamGia sp)
        {
            using (var context = DBContext.GetContext())
            {
                try
                {
                    //var trung = context.GiamGia.FirstOrDefault(ca => (ca.MaGiamGia != sp.MaGiamGia)
                    //&&
                    //    ((ca.NgayBatDau <= sp.NgayBatDau && ca.NgayKetThuc >= sp.NgayBatDau)
                    //        || (ca.NgayBatDau <= sp.NgayKetThuc && ca.NgayKetThuc >= sp.NgayKetThuc)));
                    //if (trung != null)
                    //{
                    //    return CODE_RESULT_RETURN.MaTrung;
                    //}
                    var n1 = context.GiamGia.FirstOrDefault(n => n.MaGiamGia == sp.MaGiamGia);
                    if (n1 == null)
                    {
                        context.GiamGia.Add(sp);
                        context.SaveChanges();
                        return CODE_RESULT_RETURN.ThanhCong;
                    }
                    return CODE_RESULT_RETURN.MaTrung;
                }
                catch
                {
                    return CODE_RESULT_RETURN.ThatBai;
                }
            }
        }

        internal static CODE_RESULT_RETURN Update(GiamGia hv)
        {
            using (var db = DBContext.GetContext())
            {
                //var trung = db.GiamGia.FirstOrDefault(ca => (ca.MaGiamGia != sp.MaGiamGia)
                //  &&
                //      ((ca.NgayBatDau <= sp.NgayBatDau && ca.NgayKetThuc >= sp.NgayBatDau)
                //          || (ca.NgayBatDau <= sp.NgayKetThuc && ca.NgayKetThuc >= sp.NgayKetThuc)));
                //if (trung != null)
                //{
                //    return CODE_RESULT_RETURN.MaTrung;
                //}
                var hvc = db.GiamGia.FirstOrDefault(h => h.MaGiamGia == hv.MaGiamGia);
                if (hvc != null)
                {
                    hvc.NgayKetThuc = hv.NgayKetThuc;
                    hvc.NgayBatDau = hv.NgayBatDau;
                    hvc.PhanTramGiam = hv.PhanTramGiam;
                    hvc.TenGiamGia = hv.TenGiamGia;
                    db.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        internal static CODE_RESULT_RETURN Delete(string id)
        {
            using (var context = DBContext.GetContext())
            {
                var pt = context.GiamGia.FirstOrDefault(p => p.MaGiamGia == id);
                if (pt != null)
                {
                    context.GiamGia.Remove(pt);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        public static bool IsKhongRangBuoc(GiamGia g)
        {
            using (var db = DBContext.GetContext())
            {
                var phieuThus = db.PhieuThu.Include(p => p.GiamGia).FirstOrDefault(p => p.GiamGia.MaGiamGia == g.MaGiamGia);
                if (phieuThus != null)
                    return false;
                var khachLe = db.KhachLe.Include(p => p.GiamGia).FirstOrDefault(p => p.GiamGia.MaGiamGia == g.MaGiamGia);
                if (khachLe != null)
                    return false;
                return true;
            }
        }
    }
}
