using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using my_cars.Data.Models;

namespace my_cars.EntityConfigurations
{
    public class CarModelConfiguration : EntityTypeConfiguration<CarModel>
    {
        public override void Map(EntityTypeBuilder<CarModel> modelBuilder)
        {
            modelBuilder
              .Property(t => t.Id)
              .HasColumnType("int")
              .HasMaxLength(20);

            modelBuilder
              .Property(t => t.ModelCode)
              .HasColumnType("varchar")
              .HasMaxLength(20);

            modelBuilder
              .Property(t => t.BrandCode)
              .HasColumnType("varchar")
              .HasMaxLength(20);

            modelBuilder
              .Property(t => t.ModelName)
              .HasColumnType("varchar")
              .HasMaxLength(100);

            modelBuilder
              .Property(t => t.ModelYear)
              .HasColumnType("varchar")
              .HasMaxLength(20);

            modelBuilder
              .Property(t => t.SubModelName)
              .HasColumnType("varchar")
              .HasMaxLength(100);

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

            // Nevigator Properties
            modelBuilder
             .HasIndex(t => t.CarBrandId);

            modelBuilder
             .HasIndex(t => t.AdminId);

        }
    }
}
