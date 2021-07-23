using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using my_cars.Data.Models;

namespace my_cars.EntityConfigurations
{
    public class AppointmentConfiguration : EntityTypeConfiguration<Appointment>
    {
        public override void Map(EntityTypeBuilder<Appointment> modelBuilder)
        {
            modelBuilder
                .Property(t => t.Id)
                .HasColumnType("int")
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
                .Property(t => t.CarId)
                .HasColumnType("int")
                .HasMaxLength(20);

            modelBuilder
              .HasIndex(t => t.CarId);

            modelBuilder
                .Property(t => t.CustomerId)
                .HasColumnType("int")
                .HasMaxLength(20);

            modelBuilder
              .HasIndex(t => t.CustomerId);

            modelBuilder
                .Property(t => t.GarageId)
                .HasColumnType("int")
                .HasMaxLength(20);

            modelBuilder
              .HasIndex(t => t.GarageId);
        }
    }
}
