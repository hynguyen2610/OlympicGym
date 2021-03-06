﻿using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymFitnessOlympic.Controller
{
    class PhongTapController
    {
        internal static List<PhongTap> GetByPhong(){
            using (var context = DBContext.GetContext())
            {
                var nvs = context.PhongTap;
                return nvs.ToList();
            }
        }

        internal static PhongTap GetByID(int manv)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.PhongTap.FirstOrDefault(n => n.MaPhongTap == manv);
                return nv;
            }
        }


        internal static CODE_RESULT_RETURN Add(PhongTap nv)
        {
            using (var context = DBContext.GetContext())
            {
                try
                {
                    var n1 = context.PhongTap.FirstOrDefault(n => n.MaPhongTap == nv.MaPhongTap);
                    if (n1 == null)
                    {
                        context.PhongTap.Add(nv);
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

        internal static CODE_RESULT_RETURN Update(PhongTap hv)
        {
            using (var db = DBContext.GetContext())
            {
                var hvc = db.PhongTap.FirstOrDefault(h => h.MaPhongTap  == hv.MaPhongTap);
                if (hvc != null)
                {
                    hvc.DiaChi = hv.DiaChi;
                    hvc.TenPhongTap = hv.TenPhongTap;
                    db.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        internal static CODE_RESULT_RETURN Delete(int id)
        {
            using (var context = DBContext.GetContext())
            {
                var pt = context.PhongTap.FirstOrDefault(p => p.MaPhongTap == id);
                if (pt != null)
                {
                    var sps = context.SanPham.Include(s=>s.PhongTap).Where(s => s.PhongTap.MaPhongTap == id);
                    foreach (var sp in sps) {
                        context.SanPham.Remove(sp);
                    }
                    context.PhongTap.Remove(pt);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        internal static List<PhongTap> GetList()
        {
            using (var db = DBContext.GetContext()) {
                return db.PhongTap.ToList();
            }
        }

        public static bool IsKhongRangBuoc(PhongTap g)
        {
            using (var db = DBContext.GetContext())
            {
                var goiTap = db.GoiTap.Include(p => p.PhongTap).FirstOrDefault(p => p.PhongTap.MaPhongTap == g.MaPhongTap);
                if (goiTap != null)
                    return false;
                var nhanVien = db.NhanVien.Include(p => p.PhongTap).FirstOrDefault(p => p.PhongTap.MaPhongTap == g.MaPhongTap);
                if (nhanVien != null)
                    return false;
                var hoiVien = db.HoiVien.Include(p => p.PhongTap).FirstOrDefault(p => p.PhongTap.MaPhongTap == g.MaPhongTap);
                if (hoiVien != null)
                    return false;
                var sp = db.SanPham.Include(p => p.PhongTap).FirstOrDefault(p => p.PhongTap.MaPhongTap == g.MaPhongTap);
                if (sp != null)
                    return false;
                return true;
            }
        }
    }
}
