using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using my_cars.Data.Models;

namespace my_cars.EntityConfigurations
{
    public class CarBrandConfiguration : EntityTypeConfiguration<CarBrand>
    {
        public override void Map(EntityTypeBuilder<CarBrand> modelBuilder)
        {
            modelBuilder
                .Property(t => t.Id)
                .HasColumnType("int")
                .HasMaxLength(20);

            modelBuilder
                .Property(t => t.BrandCode)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            modelBuilder
                .Property(t => t.FlagActive)
                .HasColumnType("varchar")
                .HasMaxLength(20);

            modelBuilder
                .Property(t => t.CreatedDate)
                .HasColumnType("date")
                .HasMaxLength(20);

            modelBuilder
                .Property(t => t.ModifyDate)
                .HasColumnType("date")
                .HasMaxLength(20);

            modelBuilder
                .Property(t => t.Status)
                .HasColumnType("varchar")
                .HasMaxLength(20);

            modelBuilder
               .Property(t => t.BrandName)
               .HasColumnType("varchar")
               .HasMaxLength(100);

            modelBuilder
               .Property(t => t.AdminId)
               .HasColumnType("int")
               .HasMaxLength(50); 
        }
    }
}
