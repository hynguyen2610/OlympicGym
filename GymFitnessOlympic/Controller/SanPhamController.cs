using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using GymFitnessOlympic.View.ActForm.ThongKe;
using GymFitnessOlympic.View.ActForm;

namespace GymFitnessOlympic.Controller
{
    class SanPhamController
    {
        internal static List<SanPham> GetList(int phongID = -1)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.SanPham.Include(n => n.PhongTap);
                if (phongID != -1)
                {
                    nvs = nvs.Where(n => n.PhongTap.MaPhongTap == phongID).OrderBy(s=>s.TenSanPham);
                }
                return nvs.ToList();
            }
        }

        internal static SanPham GetByID(int maSP)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.SanPham.FirstOrDefault(n => n.MaSanPham == maSP);
                return nv;
            }
        }


        internal static CODE_RESULT_RETURN Add(SanPham sp)
        {
            using (var context = DBContext.GetContext())
            {
                try
                {
                    var n1 = context.SanPham.FirstOrDefault(n => n.MaSanPham == sp.MaSanPham);
                    if (n1 == null)
                    {
                        sp.PhongTap = context.PhongTap.Find(sp.PhongTap.MaPhongTap);
                        context.SanPham.Add(sp);
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

        internal static CODE_RESULT_RETURN Update(SanPham hv)
        {
            using (var db = DBContext.GetContext())
            {
                var hvc = db.SanPham.FirstOrDefault(h => h.MaSanPham == hv.MaSanPham);
                if (hvc != null)
                {
                    hv.PhongTap = db.PhongTap.Find(hv.PhongTap.MaPhongTap);
                    hvc.TenSanPham = hv.TenSanPham;
                    hvc.Gia = hv.Gia;

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
                    context.PhongTap.Remove(pt);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        public static int ThongKeSoLuong(SanPham sp)
        {
            using (var db = DBContext.GetContext())
            {
                var cc = db.ChiTietHoaDon.Include(c => c.HoaDon).Include(c => c.SanPham).
                    Where(c => c.SanPham.MaSanPham == sp.MaSanPham);
                int nhap = cc.Where(c => c.HoaDon.IsNhap).ToList().Sum(c => c.SoLuong);
                int ban = cc.Where(c => !c.HoaDon.IsNhap).ToList().Sum(c => c.SoLuong);
                int soLuong = nhap - ban;
                return soLuong;
            }

        }

        internal static List<ThongKeSanPhamModel> ThongKeMuaVaoBanRa(DateTime start, DateTime end, int maPhong = -1,
            NhanVien nhanVienHienTai = null, bool isNhap = false)
        {
            List<ThongKeSanPhamModel> li = new List<ThongKeSanPhamModel>();
            using (var db = DBContext.GetContext())
            {
  
                var chiTietHoaDonTrongKhoang = db.ChiTietHoaDon.Include(c => c.HoaDon)
                    .Include(c => c.HoaDon.NhanVien)
                    .Include(c=>c.HoaDon.NhanVien.PhongTap).Include(c=>c.SanPham)
                    .Where(c=>c.HoaDon.NgayLap >= start && c.HoaDon.NgayLap <= end)
                    ;
                if (maPhong != -1)
                {
                    chiTietHoaDonTrongKhoang = chiTietHoaDonTrongKhoang
                        .Where(c => c.HoaDon.NhanVien.PhongTap.MaPhongTap == maPhong);
                }
              
                var tatCaHang = db.SanPham.ToList();
                var tatCaNhanVien = new List<NhanVien>();
                if (nhanVienHienTai != null && nhanVienHienTai.MaNhanVien != -1)
                {
                    tatCaNhanVien.Add(nhanVienHienTai);
                    chiTietHoaDonTrongKhoang = chiTietHoaDonTrongKhoang
                        .Where(c=>c.HoaDon.NhanVien.MaNhanVien == nhanVienHienTai.MaNhanVien);
                }
                else
                  tatCaNhanVien =  db.NhanVien.ToList();
                if (!isNhap)
                {
                    #region banHang
                    foreach (var sp in tatCaHang)
                    {
                        foreach (var nv in tatCaNhanVien)
                        {
                            ThongKeSanPhamModel tk = new ThongKeSanPhamModel()
                            {
                                SanPham = sp,
                                NhanVien = nv,
                                PhongTap = nv.PhongTap
                            };

                            tk.SoLuong = chiTietHoaDonTrongKhoang.ToList().Where(c => c.SanPham.MaSanPham == sp.MaSanPham
                                && c.HoaDon.NhanVien.MaNhanVien == nv.MaNhanVien).ToList().Sum(c => c.SoLuong);
                            tk.TongTien = chiTietHoaDonTrongKhoang.ToList()
                                .Where(c => c.SanPham.MaSanPham == sp.MaSanPham
                                && c.HoaDon.NhanVien.MaNhanVien == nv.MaNhanVien
                                ).ToList().Sum(c => c.SoLuong * c.Gia);
                            if (tk.SoLuong > 0)
                            {
                                li.Add(tk);
                            }
                        }
                    }
                    #endregion banHang
                }
                else
                {
                    #region nhapHang
                    foreach (var ct in chiTietHoaDonTrongKhoang) {
                        ThongKeSanPhamModel model = new ThongKeSanPhamModel() { 
                            NhanVien = ct.HoaDon.NhanVien,
                            PhongTap = ct.HoaDon.NhanVien.PhongTap,
                            SanPham = ct.SanPham,
                            SoLuong = ct.SoLuong,
                            TongTien = ct.ThanhTien,
                            NgayNhap = ct.HoaDon.NgayLap
                        };
                        li.Add(model);
                    }

                    #endregion nhapHang

                }

                return li.OrderBy(l=>l.NhanVien.MaNhanVien).ToList();
            }
        }

        //internal static List<ThongKeSanPhamModel> ThongKeMuaVaoBanRa(DateTime start, DateTime end, int maPhong = -1, NhanVien nhanVienHienTai = null) {
        //        List<ThongKeSanPhamModel> li = new List<ThongKeSanPhamModel>();
        //        using (var db = DBContext.GetContext())
        //        {
        //            var tatCaNhanVien = db.NhanVien;
        //          //  foreach (var nv in tatCaNhanVien) {
        //                var kq = from nv in db.NhanVien
        //                         group nv by nv.MaNhanVien  into groupNV
        //                         select new {
        //            groupNV.ToList()
        //        };

        //          //  }
        //                foreach (var t in kq) {
        //                    ThongKeSanPhamModel model = new ThongKeSanPhamModel() { 
        //                    NhanVien = t.
        //                    };
        //                }
        //        }
        //}

        internal static List<GymFitnessOlympic.View.ActForm.FrmKiemKho.ThongKeSoLuongModel>
            ThongKeSoLuong(PhongTap phong)
        {
            List<GymFitnessOlympic.View.ActForm.FrmKiemKho.ThongKeSoLuongModel> li = new List<GymFitnessOlympic.View.ActForm.FrmKiemKho.ThongKeSoLuongModel>();

            using (var db = DBContext.GetContext())
            {
                var hh = db.SanPham.ToList();
                var allChiTiet = db.ChiTietHoaDon.Include(c => c.HoaDon).Select(c => c.SanPham);
                foreach (var sp in hh)
                {
                    GymFitnessOlympic.View.ActForm.FrmKiemKho.ThongKeSoLuongModel model = new GymFitnessOlympic.View.ActForm.FrmKiemKho.ThongKeSoLuongModel();
                    model.SanPham = sp;
                    model.SoBan = db.ChiTietHoaDon.Where(c => !c.HoaDon.IsNhap && c.SanPham.MaSanPham == sp.MaSanPham).ToList().Sum(c => c.SoLuong);
                    model.TienBan = db.ChiTietHoaDon.Where(c => !c.HoaDon.IsNhap && c.SanPham.MaSanPham == sp.MaSanPham).ToList().Sum(c => c.SoLuong * c.Gia);
                    model.SoNhap = db.ChiTietHoaDon.Where(c => c.HoaDon.IsNhap && c.SanPham.MaSanPham == sp.MaSanPham).ToList().Sum(c => c.SoLuong);
                    model.TienNhap = db.ChiTietHoaDon.Where(c => c.HoaDon.IsNhap && c.SanPham.MaSanPham == sp.MaSanPham).ToList().Sum(c => c.SoLuong * c.Gia);
                    li.Add(model);
                }
                return li;
            }
        }


        public static bool IsKhongRangBuoc(SanPham g)
        {
            using (var db = DBContext.GetContext())
            {
                var ct = db.ChiTietHoaDon.Include(p => p.SanPham).FirstOrDefault(p => p.SanPham.MaPhongTap == g.MaSanPham);
                if (ct != null)
                    return false;

                return true;
            }
        }

        internal static SanPham GetByMa(string ma)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.SanPham.FirstOrDefault(n => n.MaVachSanPham
                    == ma);
                return nv;
            }
        }
    }
}
