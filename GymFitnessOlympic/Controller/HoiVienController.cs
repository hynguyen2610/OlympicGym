using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using GymFitnessOlympic.Models.Util;

namespace GymFitnessOlympic.Controller
{
    class HoiVienController
    {
        internal static List<HoiVien> GetList(int phongID = -1)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.HoiVien.Include(n => n.PhongTap);
                if (phongID != -1)
                {
                    nvs = nvs.Where(n => n.PhongTap.MaPhongTap == phongID);
                }
                return nvs.
                    OrderByDescending(h => h.GiaHanCuoiGYM)
                    .OrderByDescending(h => h.GiaHanCuoiSauna)
                    .OrderByDescending(h => h.NgayGioDangKy).ToList();
            }
        }

        internal static HoiVien GetHoiVien(int manv)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.HoiVien.Include(h => h.PhongTap);
                //if(isGoiTap){
                return nvs.FirstOrDefault(h => h.MaHoiVien == manv);
                //}
                // return nvs.FirstOrDefault(n => n.MaVachSauna == manv);
            }
        }

        internal static HoiVien GetByMaHoiVien(string mahoivien)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.HoiVien.Include(h => h.PhongTap);
                //yif(isGYM)
                return nvs.FirstOrDefault(h => h.MaThe == mahoivien);
                // return nvs.FirstOrDefault(h => h.MaSauna == manv);
                //}
                // return nvs.FirstOrDefault(n => n.MaVachSauna == manv);
            }
        }

        internal static CODE_RESULT_RETURN Update(HoiVien hv)
        {
            using (var db = DBContext.GetContext())
            {
                var hvc = db.HoiVien.FirstOrDefault(h => h.MaThe == hv.MaThe);
                if (hvc != null)
                {
                    hvc.NgayHetHanGYM = hv.NgayHetHanGYM;
                    hvc.NgaySinh = hv.NgaySinh;
                    //hvc.MaSauna = hv.MaSauna;
                    hvc.TenHoiVien = hv.TenHoiVien;
                    hvc.Anh = hv.Anh; ;
                    hvc.DiaChi = hv.DiaChi;
                    hvc.GioiTinh = hv.GioiTinh;
                    hvc.SoDienThoai = hv.SoDienThoai;

                    if (hv.PhongTap != null)
                    {
                        var phongMoi = db.PhongTap.FirstOrDefault(p => p.MaPhongTap == hv.PhongTap.MaPhongTap);
                        hvc.PhongTap = phongMoi;
                    }
                    db.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        internal static CODE_RESULT_RETURN Add(HoiVien hv)
        {
            using (var context = DBContext.GetContext())
            {
                var ds = (from e in context.HoiVien
                          where e.MaThe == hv.MaThe
                          select e).SingleOrDefault();
                if (ds != null)
                    return CODE_RESULT_RETURN.MaTrung;
                else
                {
                    var phong = context.PhongTap.Find(hv.PhongTap.MaPhongTap);
                    hv.PhongTap = phong;

                    context.HoiVien.Add(hv);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }

            }
        }

        internal static CODE_RESULT_RETURN Delete(int id)
        {
            using (var context = DBContext.GetContext())
            {
                var pt = context.HoiVien.FirstOrDefault(p => p.MaHoiVien == id);
                if (pt != null)
                {
                    var pts = context.PhieuThu.Include(p => p.HoiVien)
                        .Where(p => p.HoiVien.MaHoiVien == id);
                    foreach (var a1 in pts) {
                        context.PhieuThu.Remove(a1);
                    }
                    context.HoiVien.Remove(pt);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }



        internal static CODE_RESULT_RETURN updateNgayHetHan(HoiVien hoiVien)
        {
            using (var context = DBContext.GetContext())
            {
                var pt = context.HoiVien.FirstOrDefault(p => p.MaThe == hoiVien.MaThe);
                if (pt != null)
                {
                    pt.NgayHetHanGYM = hoiVien.NgayHetHanGYM;
                    pt.NgayHetHanSauNa = hoiVien.NgayHetHanSauNa;
                    pt.GiaHanCuoiGYM = DateTime.Now;
                    pt.GiaHanCuoiSauna = DateTime.Now;
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        internal static List<HoiVien> GetComingBirthDay()
        {
            try
            {
                var delta = int.Parse(KeyValueController.Get("NSN"));
                var hs = new List<HoiVien>();
                var all = GetList(Login1.GetPhongHienTai().MaPhongTap);
                foreach(var h in all){
                    if (h.SoNgayTruocSinhNhat <= delta && h.SoNgayTruocSinhNhat >=0) {
                        hs.Add(h);
                    }
                }
                return hs;

            }
            catch
            {
                return null;
            }
        }

        internal static List<HoiVien> GetDangKyNhanhTrongNgay(PhongTap p)
        {
            var dauNgay = DateTimeUtil.StartOfDay(DateTime.Now);
            var cuoiNgay = DateTimeUtil.EndOfDay(DateTime.Now);
            using (var db = DBContext.GetContext())
            {
                var hs =db.HoiVien.Include(h=>h.PhongTap).Include(h=>h.DanhSachPhieuThu).Where(h=>
                    //h.IsDangKyNhanh
                    //&&
                    h.PhongTap.MaPhongTap == p.MaPhongTap
                    &&
                    h.NgayGioDangKy >= dauNgay && h.NgayGioDangKy <=cuoiNgay).OrderByDescending(d=>d.NgayGioDangKy).ToList();
                return hs;
            }
        }

        public static int TongTienDknTrongNgay() {
            using (var db = DBContext.GetContext()) {
                var start = DateTimeUtil.StartOfDay( DateTime.Now);
                var end = DateTimeUtil.EndOfDay(DateTime.Now);
                var pts = db.PhieuThu.Include(p => p.HoiVien)
                    .Where(p => p.HoiVien.NgayGioDangKy >= start && p.HoiVien.NgayGioDangKy <= end);
                return pts.ToList().Sum(p => p.SoTien);
            }
        }

        public static bool IsKhongRangBuoc(HoiVien g)
        {
            using (var db = DBContext.GetContext())
            {
                var phieuThus = db.PhieuThu.Include(p => p.HoiVien).FirstOrDefault(p => p.HoiVien.MaHoiVien == g.MaHoiVien);
                if (phieuThus != null)
                    return false;
                var his = db.HistoryHoiVien.Include(p => p.HoiVien).FirstOrDefault(p => p.HoiVien.MaHoiVien == g.MaHoiVien);
                if (his != null)
                    return false;
                return true;
            }
        }

    }
}
