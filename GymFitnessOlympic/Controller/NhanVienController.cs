using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using GymFitnessOlympic.Models.Util;
using System.Data.Entity.Validation;
using System.Diagnostics;
using GymFitnessOlympic.View.UserControls;

namespace GymFitnessOlympic.Controller
{
    class NhanVienController
    {
        internal static List<NhanVien> GetList(int khoa = -1, 
            int conLamViec = -1, int phongID = -1)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.NhanVien.Include(n => n.PhongTap).Include(n=>n.Quyen);
                var la = nvs.ToList();
                if (khoa != -1) {
                    if (khoa == 0)
                    {
                        nvs = nvs.Where(n => !n.IsKhoa);
                    }
                    else {
                        nvs = nvs.Where(n => n.IsKhoa);
                    }
                }
                if (conLamViec != -1)
                {
                    if (conLamViec == 0)
                    {
                        nvs = nvs.Where(n => n.IsConLamViec);
                    }
                    else
                    {
                        nvs = nvs.Where(n => !n.IsConLamViec);
                    }
                }
                if (phongID != -1)
                {
                    nvs = nvs.Where(n => n.PhongTap.MaPhongTap == phongID);
                }
                var li =  nvs.ToList();
                return li;
            }
        }


        internal static NhanVien GetByID(int maSP = -1)
        {
            using (var context = DBContext.GetContext())
            {
                if (maSP == -1)
                    return context.NhanVien.FirstOrDefault();
                var nv = context.NhanVien.FirstOrDefault(n => n.MaNhanVien == maSP);
                return nv;
            }
        }

        public static PhongTap GetPhong(int maNV) {
            using (var context = DBContext.GetContext())
            {
                var nv = context.PhongTap.FirstOrDefault(p=>p.DanhSachNhanVien.Select(n=>n.MaNhanVien).Contains(maNV));
                return nv;
            } 
        }

        internal static NhanVien GetByMaThe(string maSP)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.NhanVien.Include(n => n.PhongTap).FirstOrDefault(n => n.MaThe == maSP);
                return nv;
            }
        }

        internal static bool IsCheckedIn(string maSP)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.HistoryNhanVien.OrderByDescending(h=>h.ThoiGian).FirstOrDefault(n => n.NhanVien.MaThe == maSP);
                return (nv!=null && nv.IsCheckin);
                
            }
        }

        internal static bool IsCheckedOut(string maSP)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.HistoryNhanVien.OrderByDescending(h => h.ThoiGian).FirstOrDefault(n => n.NhanVien.MaThe == maSP);
                return (nv == null ||  !nv.IsCheckin);

            }
        }


        internal static CODE_RESULT_RETURN Add(NhanVien nv)
        {
            using (var context = DBContext.GetContext())
            {
                try
                {
                    var n1 = context.NhanVien.FirstOrDefault(n => n.MaNhanVien == nv.MaNhanVien);
                    if (n1 == null)
                    {
                        //nv.Password = CryptoMd5.MD5Hash(nv.Password);
                        var quyen = context.Quyen.Find(nv.Quyen.MaQuyen);
                        var phong = context.PhongTap.Find(nv.PhongTap.MaPhongTap);
                        nv.Quyen = quyen;
                        nv.PhongTap = phong;
                        context.NhanVien.Add(nv);
                        context.SaveChanges();
                        return CODE_RESULT_RETURN.ThanhCong;
                    }
                    return CODE_RESULT_RETURN.MaTrung;
                }
                catch (DbEntityValidationException dbEx) {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}",
                                                    validationError.PropertyName,
                                                    validationError.ErrorMessage);
                        }
                    }
                    return CODE_RESULT_RETURN.ThatBai;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return CODE_RESULT_RETURN.ThatBai;
                }
            }
        }

        internal static CODE_RESULT_RETURN Update(NhanVien hv)
        {
            using (var db = DBContext.GetContext())
            {
                var nhanVienCu = db.NhanVien.FirstOrDefault(h => h.MaNhanVien == hv.MaNhanVien);
                if (nhanVienCu != null)
                {
                    nhanVienCu.TenNhanVien = hv.TenNhanVien;
                    nhanVienCu.UserName = hv.UserName;
                    if (hv.PhongTap != null)
                    {
                        var phongMoi = db.PhongTap.FirstOrDefault(p => p.MaPhongTap == hv.PhongTap.MaPhongTap);
                        nhanVienCu.PhongTap = phongMoi;
                    }
                    var quyen = db.Quyen.Find(hv.Quyen.MaQuyen);
                    nhanVienCu.NgaySinh = hv.NgaySinh;
                    nhanVienCu.Quyen = quyen;
                    nhanVienCu.SoDienThoai = hv.SoDienThoai;
                    nhanVienCu.DiaChi = hv.DiaChi;
                    nhanVienCu.Password = hv.Password;
                    nhanVienCu.IsKhoa = hv.IsKhoa;
                    nhanVienCu.IsConLamViec = hv.IsConLamViec;
                    nhanVienCu.Anh = hv.Anh;
                    nhanVienCu.MaThe = hv.MaThe;
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
                var pt = context.NhanVien.FirstOrDefault(p => p.MaNhanVien == id);
                if (pt != null)
                {
                    context.NhanVien.Remove(pt);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

       static string maHoa(String s) {
            return s;
        }

        internal static NhanVien Login(string tenDangNhap, string matKhau)
        {
            var hash = CryptoMd5.MD5Hash(matKhau);
            using (var context = DBContext.GetContext())
            {
                var pt = context.NhanVien.Include(n=>n.Quyen).FirstOrDefault(p => p.UserName == tenDangNhap &&   p.Password ==hash);
                return pt;
            }
        }

        internal static void ChangePassword(NhanVien m_NguoiSuDung, string matKhauMoi)
        {
            using (var db = DBContext.GetContext())
            {
                NhanVien nguoiSuDung = db.NhanVien.Where(
                    nsd => nsd.UserName == m_NguoiSuDung.UserName &&
                        nsd.Password == m_NguoiSuDung.Password).FirstOrDefault();
                if (nguoiSuDung == null)
                    throw new Exception("Thông tin người sử dụng không đúng!");
                else
                {
                    try
                    {
                        nguoiSuDung.Password =CryptoMd5.MD5Hash( matKhauMoi);
                        db.SaveChanges();
                    }
                    catch
                    {
                        throw new Exception("Không thể thay đổi mật khẩu được!");
                    }
                }
            }
        }

        internal static NhanVien GetFirst()
        {
            using (var db = DBContext.GetContext()) {
                return db.NhanVien.FirstOrDefault();
            }
        }

        public static bool IsKhongRangBuoc(NhanVien g)
        {
            using (var db = DBContext.GetContext())
            {
                var phieuThus = db.PhieuThu.Include(p => p.NhanVien).FirstOrDefault(p => p.NhanVien.MaNhanVien == g.MaNhanVien);
                if (phieuThus != null)
                    return false;
                var his = db.HistoryNhanVien.Include(p => p.NhanVien).FirstOrDefault(p => p.NhanVien.MaNhanVien == g.MaNhanVien);
                if (his != null)
                    return false;
                var khachLe = db.KhachLe.Include(p => p.NhanVien).FirstOrDefault(p => p.NhanVien.MaNhanVien == g.MaNhanVien);
                if (his != null)
                    return false;
                var hoaDon = db.HoaDon.Include(p => p.NhanVien).FirstOrDefault(p => p.NhanVien.MaNhanVien == g.MaNhanVien);
                if (hoaDon != null)
                    return false;
                if (g.MaNhanVien == Login1.TaiKhoanHienTai.MaNhanVien)
                    return false;
                return true;
            }
        }


        internal static bool IsTrungMaNvKhac(NhanVien current)
        {
            var t = GetByMaThe(current.MaThe);
            return t != null && t.MaNhanVien != current.MaNhanVien;
        }
    }
}
