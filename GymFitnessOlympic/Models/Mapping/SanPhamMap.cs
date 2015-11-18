using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.Mapping
{
    class SanPhamMap : EntityTypeConfiguration<SanPham>
    {
        public SanPhamMap()
            {
                // Khoá chính
                this.HasKey(t => t.MaSanPham);
                //Các cột
                this.Property(t => t.TenSanPham).IsRequired();
                this.Property(t => t.Gia).IsRequired();
                this.Property(t => t.MaVachSanPham).IsRequired();
                this.ToTable("SanPham");
            }
    }
}
