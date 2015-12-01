using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymFitnessOlympic.Controller
{
    class PhieuThuController
    {
        internal static List<PhieuThu> GetList(int maPhong, NhanVien nv = null)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.PhieuThu.Include(n => n.HoiVien)
                    .Include(n => n.NhanVien).Include(p=>p.NhanVien.PhongTap)
                    .Include(p=>p.GoiTap)
                    ;
                if (maPhong != -1) {
                    nvs = nvs.Where(n => n.NhanVien.PhongTap.MaPhongTap == maPhong);
                }
                if (nv != null && nv.MaNhanVien != -1)
                {
                    nvs = nvs.Where(n => n.NhanVien.MaNhanVien == nv.MaNhanVien);
                }
                return nvs.ToList();
            }
        }

        internal static PhieuThu GetPhieuThu(int manv)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.PhieuThu.FirstOrDefault(n => n.MaPhieuThu == manv);
                return nv;
            }
        }

        internal static CODE_RESULT_RETURN Update(PhieuThu phieuThuMoi)
        {
            using (var db = DBContext.GetContext())
            {
                var phieuThuCu = db.PhieuThu.FirstOrDefault(h => h.MaPhieuThu == phieuThuMoi.MaPhieuThu);
                if (phieuThuCu != null)
                {
                    phieuThuCu.NgayLap = phieuThuMoi.NgayLap;
                    phieuThuCu.SoTien = phieuThuMoi.SoTien;
                    try
                    {
                        var nhanVienMoi = db.NhanVien.FirstOrDefault(n => n.MaNhanVien == phieuThuMoi.NhanVien.MaNhanVien);
                        if (nhanVienMoi != null)
                        {
                            phieuThuCu.NhanVien = nhanVienMoi;
                        }
                    }
                    catch
                    {

                    }
                    db.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        internal static CODE_RESULT_RETURN Add(PhieuThu pt)
        {
            using (var context = DBContext.GetContext())
            {
                var ds = (from e in context.PhieuThu
                          where e.MaPhieuThu == pt.MaPhieuThu
                          select e).SingleOrDefault();
                if (ds != null)
                    return CODE_RESULT_RETURN.MaTrung;
                else
                {
                    var h = context.HoiVien.Find(pt.HoiVien.MaHoiVien);
                    pt.HoiVien = h;
                    var g = context.GoiTap.Find(pt.GoiTap.MaGoiTap);
                    pt.GoiTap = g;
                    pt.NhanVien = context.NhanVien.Find(pt.NhanVien.MaNhanVien);
                    //if (pt.GiamGia != null && pt.GiamGia.MaGiamGia != "") {
                    //    pt.GiamGia = context.GiamGia.Find(pt.GiamGia.MaGiamGia);
                    //}
                    context.PhieuThu.Add(pt);
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex) {
                        var s = ex.Message;
                    }
                    if (pt.GoiTap.Type == 1)
                    {
                        if (pt.HoiVien.NgayHetHanGYM > DateTime.Now)
                            pt.HoiVien.NgayHetHanGYM = pt.HoiVien.NgayHetHanGYM.AddMonths(pt.GoiTap.SoThang);
                        else
                            pt.HoiVien.NgayHetHanGYM = DateTime.Now.AddMonths(pt.GoiTap.SoThang);
                        pt.HoiVien.GiaHanCuoiGYM = DateTime.Now;
                    }
                    else
                    {
                        if (pt.HoiVien.NgayHetHanSauNa > DateTime.Now)
                            pt.HoiVien.NgayHetHanSauNa = pt.HoiVien.NgayHetHanSauNa.AddMonths(pt.GoiTap.SoThang);
                        else
                            pt.HoiVien.NgayHetHanSauNa = DateTime.Now.AddMonths(pt.GoiTap.SoThang);
                        pt.HoiVien.GiaHanCuoiSauna = DateTime.Now;
                    }
                    //if (pt.GiamGia != null) {
                    //    pt.GiamGia = context.GiamGia.Find(pt.GiamGia.MaGiamGia);
                    //}
                    var r = HoiVienController.updateNgayHetHan(pt.HoiVien);
                    if (r == CODE_RESULT_RETURN.ThanhCong)
                    {
                        return CODE_RESULT_RETURN.ThanhCong;
                    }
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }





        internal static CODE_RESULT_RETURN Delete(int id)
        {
            using (var context = DBContext.GetContext())
            {
                var pt = context.PhieuThu.FirstOrDefault(p => p.MaPhieuThu == id);
                if (pt != null)
                {
                    context.PhieuThu.Remove(pt);
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }

        }
    }
}
