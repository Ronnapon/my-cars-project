using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using my_cars.Data.Models;

namespace my_cars.EntityConfigurations
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public override void Map(EntityTypeBuilder<Employee> modelBuilder)
        {
            modelBuilder
                .Property(t => t.Id)
                .HasColumnType("int")
                .HasMaxLength(20);

            modelBuilder
                .Property(t => t.Fname)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            modelBuilder
                .Property(t => t.Lname)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            modelBuilder
                .Property(t => t.Tel)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            modelBuilder
                .Property(t => t.Address)
                .HasColumnType("varchar")
                .HasMaxLength(200);

            modelBuilder
                .Property(t => t.Position)
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
                .Property(t => t.TitleId)
                .HasColumnType("int")
                .HasMaxLength(20);

            modelBuilder
                .Property(t => t.GarageId)
                .HasColumnType("int")
                .HasMaxLength(20);
        }
    }
}
