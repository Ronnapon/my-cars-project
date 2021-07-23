using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using my_cars.Data.Models;

namespace my_cars.EntityConfigurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public override void Map(EntityTypeBuilder<Customer> modelBuilder)
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
                .HasMaxLength(100);

            modelBuilder
                .Property(t => t.Email)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            modelBuilder
                .Property(t => t.Gender)
                .HasColumnType("varchar")
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
                .Property(t => t.TitleId)
                .HasColumnType("int")
                .HasMaxLength(20);

            modelBuilder
             .HasIndex(t => t.TitleId);
        }
    }
}
