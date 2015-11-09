using GymFitnessOlympic.Models.entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.Mapping
{
    class KhachLeMap : EntityTypeConfiguration<KhachLe>
    {
        public KhachLeMap() {
            this.HasKey(t => t.ThoiGian);

            this.ToTable("KhachLe");
        }
    }
}
