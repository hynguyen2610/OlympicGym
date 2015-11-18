using GymFitnessOlympic.Models.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public class NhanVien
    {
 
        public int MaNhanVien { get; set; }
        public string MaThe { get; set; }
        public string TenNhanVien { get; set; }
        public bool GioiTinh { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get;set;}
        public Quyen Quyen { get; set; }
        public byte[] Anh { get; set; }
        public PhongTap PhongTap { get; set; }
        public List<PhieuThu> DanhSachPhieuThu { get; set; }
        public List<HoaDon> DanhSachHoaDon { get; set; }
        public List<HistoryNhanVien> LichSu { get; set; }
        public List<KhachLe> KhachLe { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool IsKhoa { get; set; }
        public bool IsConLamViec { get; set; }

        public NhanVien() {
            IsKhoa = false;
            IsConLamViec = true;
        }

        public override string ToString()
        {
            return TenNhanVien;
        }

        public String KhoaString {
            get { 
                return IsKhoa ?"Đã bị khóa" : "Không khóa";
            }
        }

        public String ConLamViecString {
            get {
                return IsConLamViec ? "Còn làm việc" : "Đã nghỉ";
            }
        }

        public string TenPhong {
            get {
                return PhongTap.TenPhongTap;
            }
        }

    }
}
