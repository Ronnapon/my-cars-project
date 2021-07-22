using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using my_cars.Data.Models;

namespace my_cars.EntityConfigurations
{
    public class CarConfiguration : EntityTypeConfiguration<Car>
    {
        public override void Map(EntityTypeBuilder<Car> modelBuilder)
        {
            modelBuilder
                .Property(t => t.Id)
                .HasColumnType("int")
                .HasMaxLength(20);

            modelBuilder
                .Property(t => t.LicenseId)
                .HasColumnType("int")
                .HasMaxLength(20);

            modelBuilder
                .Property(t => t.Province)
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

            modelBuilder
               .Property(t => t.CarBrandId)
               .HasColumnType("int")
               .HasMaxLength(20);

            modelBuilder
               .Property(t => t.CarModelId)
               .HasColumnType("int")
               .HasMaxLength(20);

            modelBuilder
               .Property(t => t.CustomerId)
               .HasColumnType("int")
               .HasMaxLength(20);

        }
    }
}
