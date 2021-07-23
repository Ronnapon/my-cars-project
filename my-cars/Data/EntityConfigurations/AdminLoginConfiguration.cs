using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using my_cars.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_cars.EntityConfigurations
{
    public class AdminLoginConfiguration : EntityTypeConfiguration<AdminLogin>
    {
        public override void Map(EntityTypeBuilder<AdminLogin> modelBuilder)
        {
            modelBuilder
                .Property(t => t.Id)
                .HasColumnType("int")
                .HasMaxLength(20);

            modelBuilder
               .Property(t => t.UserName)
               .HasColumnType("varchar")
               .HasMaxLength(100);

            modelBuilder
               .Property(t => t.UserPass)
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
               .Property(t => t.AdminId)
               .HasColumnType("int")
               .HasMaxLength(20);

            modelBuilder
              .HasIndex(t => t.AdminId);
        }
    }
} 

