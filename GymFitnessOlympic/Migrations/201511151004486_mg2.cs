namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppUser",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 50),
                        FullName = c.String(nullable: false, maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 255),
                        Role = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.CaLamViecs",
                c => new
                    {
                        MaCa = c.Int(nullable: false, identity: true),
                        TenCa = c.String(),
                        GioBatDau = c.Time(nullable: false, precision: 7),
                        GioKetThuc = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.MaCa);
            
            CreateTable(
                "dbo.ChiTietHoaDon",
                c => new
                    {
                        MaHoaDon = c.Int(nullable: false),
                        MaSanPham = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        Gia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaHoaDon, t.MaSanPham })
                .ForeignKey("dbo.HoaDon", t => t.MaHoaDon, cascadeDelete: true)
                .ForeignKey("dbo.SanPham", t => t.MaSanPham, cascadeDelete: true)
                .Index(t => t.MaHoaDon)
                .Index(t => t.MaSanPham);
            
            CreateTable(
                "dbo.HoaDon",
                c => new
                    {
                        MaHoaDon = c.Int(nullable: false, identity: true),
                        NgayLap = c.DateTime(nullable: false),
                        IsNhap = c.Boolean(nullable: false),
                        NhanVien_MaNhanVien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaHoaDon)
                .ForeignKey("dbo.NhanVien", t => t.NhanVien_MaNhanVien, cascadeDelete: true)
                .Index(t => t.NhanVien_MaNhanVien);
            
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        MaNhanVien = c.Int(nullable: false, identity: true),
                        MaThe = c.String(),
                        TenNhanVien = c.String(nullable: false, maxLength: 50),
                        GioiTinh = c.Boolean(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false),
                        DiaChi = c.String(),
                        SoDienThoai = c.String(),
                        Anh = c.Binary(),
                        PhongTap_MaPhongTap = c.Int(nullable: false),
                        Quyen_MaQuyen = c.Int(),
                    })
                .PrimaryKey(t => t.MaNhanVien)
                .ForeignKey("dbo.PhongTap", t => t.PhongTap_MaPhongTap, cascadeDelete: true)
                .ForeignKey("dbo.Quyen", t => t.Quyen_MaQuyen)
                .Index(t => t.PhongTap_MaPhongTap)
                .Index(t => t.Quyen_MaQuyen);
            
            CreateTable(
                "dbo.PhieuThu",
                c => new
                    {
                        MaPhieuThu = c.Int(nullable: false, identity: true),
                        NgayLap = c.DateTime(nullable: false),
                        SoTien = c.Int(nullable: false),
                        LyDo = c.String(),
                        GoiTap_MaGoiTap = c.Int(),
                        HoiVien_MaHoiVien = c.Int(),
                        NhanVien_MaNhanVien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuThu)
                .ForeignKey("dbo.GoiTap", t => t.GoiTap_MaGoiTap)
                .ForeignKey("dbo.HoiVien", t => t.HoiVien_MaHoiVien)
                .ForeignKey("dbo.NhanVien", t => t.NhanVien_MaNhanVien, cascadeDelete: true)
                .Index(t => t.GoiTap_MaGoiTap)
                .Index(t => t.HoiVien_MaHoiVien)
                .Index(t => t.NhanVien_MaNhanVien);
            
            CreateTable(
                "dbo.GoiTap",
                c => new
                    {
                        MaGoiTap = c.Int(nullable: false, identity: true),
                        TenGoiTap = c.String(),
                        Gia = c.Int(nullable: false),
                        SoThang = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        PhongTap_MaPhongTap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaGoiTap)
                .ForeignKey("dbo.PhongTap", t => t.PhongTap_MaPhongTap, cascadeDelete: true)
                .Index(t => t.PhongTap_MaPhongTap);
            
            CreateTable(
                "dbo.PhongTap",
                c => new
                    {
                        MaPhongTap = c.Int(nullable: false, identity: true),
                        TenPhongTap = c.String(nullable: false),
                        DiaChi = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhongTap);
            
            CreateTable(
                "dbo.HoiVien",
                c => new
                    {
                        MaHoiVien = c.Int(nullable: false, identity: true),
                        MaThe = c.String(),
                        TenHoiVien = c.String(nullable: false, maxLength: 50),
                        GioiTinh = c.Boolean(nullable: false),
                        DiaChi = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                        SoDienThoai = c.String(),
                        NgayHetHanGYM = c.DateTime(nullable: false),
                        NgayHetHanSauNa = c.DateTime(nullable: false),
                        GiaHanCuoiGYM = c.DateTime(nullable: false),
                        GiaHanCuoiSauna = c.DateTime(nullable: false),
                        MaPhongTap = c.Int(nullable: false),
                        Anh = c.Binary(),
                        NgayGioDangKy = c.DateTime(nullable: false),
                        IsDangKyNhanh = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaHoiVien)
                .ForeignKey("dbo.PhongTap", t => t.MaPhongTap, cascadeDelete: true)
                .Index(t => t.MaPhongTap);
            
            CreateTable(
                "dbo.HistoryHoiVien",
                c => new
                    {
                        ThoiGian = c.DateTime(nullable: false),
                        IsDaInGYM = c.Boolean(nullable: false),
                        IsDaInSauna = c.Boolean(nullable: false),
                        HoiVien_MaHoiVien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ThoiGian)
                .ForeignKey("dbo.HoiVien", t => t.HoiVien_MaHoiVien, cascadeDelete: true)
                .Index(t => t.HoiVien_MaHoiVien);
            
            CreateTable(
                "dbo.SanPham",
                c => new
                    {
                        MaSanPham = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(nullable: false),
                        Gia = c.Int(nullable: false),
                        MaPhongTap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSanPham)
                .ForeignKey("dbo.PhongTap", t => t.MaPhongTap)
                .Index(t => t.MaPhongTap);
            
            CreateTable(
                "dbo.KhachLe",
                c => new
                    {
                        ThoiGian = c.DateTime(nullable: false),
                        SoTien = c.Int(nullable: false),
                        IsGYM = c.Boolean(nullable: false),
                        NhanVien_MaNhanVien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ThoiGian)
                .ForeignKey("dbo.NhanVien", t => t.NhanVien_MaNhanVien, cascadeDelete: true)
                .Index(t => t.NhanVien_MaNhanVien);
            
            CreateTable(
                "dbo.HistoryNhanVien",
                c => new
                    {
                        ThoiGian = c.DateTime(nullable: false),
                        IsCheckin = c.Boolean(nullable: false),
                        Ca_MaCa = c.Int(),
                        NhanVien_MaNhanVien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ThoiGian)
                .ForeignKey("dbo.CaLamViecs", t => t.Ca_MaCa)
                .ForeignKey("dbo.NhanVien", t => t.NhanVien_MaNhanVien, cascadeDelete: true)
                .Index(t => t.Ca_MaCa)
                .Index(t => t.NhanVien_MaNhanVien);
            
            CreateTable(
                "dbo.Quyen",
                c => new
                    {
                        MaQuyen = c.Int(nullable: false, identity: true),
                        TenQuyen = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaQuyen);
            
            CreateTable(
                "dbo.GiamGia",
                c => new
                    {
                        MaGiamGia = c.String(nullable: false, maxLength: 128),
                        TenGiamGia = c.String(maxLength: 255),
                        NgayDau = c.DateTime(nullable: false),
                        NgayCuoi = c.DateTime(nullable: false),
                        PhanTramGiam = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MaGiamGia);
            
            CreateTable(
                "dbo.AppConfig",
                c => new
                    {
                        _Key = c.String(nullable: false, maxLength: 50),
                        Value = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t._Key);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietHoaDon", "MaSanPham", "dbo.SanPham");
            DropForeignKey("dbo.ChiTietHoaDon", "MaHoaDon", "dbo.HoaDon");
            DropForeignKey("dbo.HoaDon", "NhanVien_MaNhanVien", "dbo.NhanVien");
            DropForeignKey("dbo.NhanVien", "Quyen_MaQuyen", "dbo.Quyen");
            DropForeignKey("dbo.NhanVien", "PhongTap_MaPhongTap", "dbo.PhongTap");
            DropForeignKey("dbo.HistoryNhanVien", "NhanVien_MaNhanVien", "dbo.NhanVien");
            DropForeignKey("dbo.HistoryNhanVien", "Ca_MaCa", "dbo.CaLamViecs");
            DropForeignKey("dbo.KhachLe", "NhanVien_MaNhanVien", "dbo.NhanVien");
            DropForeignKey("dbo.PhieuThu", "NhanVien_MaNhanVien", "dbo.NhanVien");
            DropForeignKey("dbo.PhieuThu", "HoiVien_MaHoiVien", "dbo.HoiVien");
            DropForeignKey("dbo.GoiTap", "PhongTap_MaPhongTap", "dbo.PhongTap");
            DropForeignKey("dbo.SanPham", "MaPhongTap", "dbo.PhongTap");
            DropForeignKey("dbo.HoiVien", "MaPhongTap", "dbo.PhongTap");
            DropForeignKey("dbo.HistoryHoiVien", "HoiVien_MaHoiVien", "dbo.HoiVien");
            DropForeignKey("dbo.PhieuThu", "GoiTap_MaGoiTap", "dbo.GoiTap");
            DropIndex("dbo.HistoryNhanVien", new[] { "NhanVien_MaNhanVien" });
            DropIndex("dbo.HistoryNhanVien", new[] { "Ca_MaCa" });
            DropIndex("dbo.KhachLe", new[] { "NhanVien_MaNhanVien" });
            DropIndex("dbo.SanPham", new[] { "MaPhongTap" });
            DropIndex("dbo.HistoryHoiVien", new[] { "HoiVien_MaHoiVien" });
            DropIndex("dbo.HoiVien", new[] { "MaPhongTap" });
            DropIndex("dbo.GoiTap", new[] { "PhongTap_MaPhongTap" });
            DropIndex("dbo.PhieuThu", new[] { "NhanVien_MaNhanVien" });
            DropIndex("dbo.PhieuThu", new[] { "HoiVien_MaHoiVien" });
            DropIndex("dbo.PhieuThu", new[] { "GoiTap_MaGoiTap" });
            DropIndex("dbo.NhanVien", new[] { "Quyen_MaQuyen" });
            DropIndex("dbo.NhanVien", new[] { "PhongTap_MaPhongTap" });
            DropIndex("dbo.HoaDon", new[] { "NhanVien_MaNhanVien" });
            DropIndex("dbo.ChiTietHoaDon", new[] { "MaSanPham" });
            DropIndex("dbo.ChiTietHoaDon", new[] { "MaHoaDon" });
            DropTable("dbo.AppConfig");
            DropTable("dbo.GiamGia");
            DropTable("dbo.Quyen");
            DropTable("dbo.HistoryNhanVien");
            DropTable("dbo.KhachLe");
            DropTable("dbo.SanPham");
            DropTable("dbo.HistoryHoiVien");
            DropTable("dbo.HoiVien");
            DropTable("dbo.PhongTap");
            DropTable("dbo.GoiTap");
            DropTable("dbo.PhieuThu");
            DropTable("dbo.NhanVien");
            DropTable("dbo.HoaDon");
            DropTable("dbo.ChiTietHoaDon");
            DropTable("dbo.CaLamViecs");
            DropTable("dbo.AppUser");
        }
    }
}
