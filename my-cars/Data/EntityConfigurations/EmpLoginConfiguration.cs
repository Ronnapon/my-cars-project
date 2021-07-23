using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using my_cars.Data.Models;

namespace my_cars.EntityConfigurations
{
    public class EmpLoginConfiguration : EntityTypeConfiguration<EmpLogin>
    {
        public override void Map(EntityTypeBuilder<EmpLogin> modelBuilder)
        {
            modelBuilder
                .Property(t => t.Id)
                .HasColumnType("varchar")
                .HasMaxLength(20);

            modelBuilder
                .Property(t => t.UserName)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            modelBuilder
                .Property(t => t.UserPass)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            modelBuilder
                .Property(t => t.ExpirePass)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            modelBuilder
                .Property(t => t.ExpiryDate)
                .HasColumnType("date")
                .HasMaxLength(20);
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
                .Property(t => t.EmployeeId)
                .HasColumnType("int")
                .HasMaxLength(20);

            modelBuilder
             .HasIndex(t => t.EmployeeId);
        }
    }
}
