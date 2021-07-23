using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using my_cars.Data.Models;

namespace my_cars.EntityConfigurations
{
    public class AppointmentDetailConfiguration : EntityTypeConfiguration<AppointmentDetail>
    {
        public override void Map(EntityTypeBuilder<AppointmentDetail> modelBuilder)
        {
            modelBuilder
                .Property(t => t.Id)
                .HasColumnType("int")
                .HasMaxLength(20);

            modelBuilder
                .Property(t => t.AppDate)
                .HasColumnType("date")
                .HasMaxLength(20);

            modelBuilder
                .Property(t => t.AppTime)
                .HasColumnType("datetime")
                .HasMaxLength(20);

            modelBuilder
                .Property(t => t.Postpone)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            modelBuilder
                .Property(t => t.FinishDate)
                .HasColumnType("date")
                .HasMaxLength(20);

            modelBuilder
                .Property(t => t.ConfirmDate)
                .HasColumnType("date")
                .HasMaxLength(20);

            modelBuilder
                .Property(t => t.CancelDate)
                .HasColumnType("date")
                .HasMaxLength(20);

            modelBuilder
                .Property(t => t.ReasonDesc)
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
                .Property(t => t.AppointmentId)
                .HasColumnType("int")
                .HasMaxLength(20);

            modelBuilder
              .HasIndex(t => t.AppointmentId);

            modelBuilder
                .Property(t => t.EmployeeId)
                .HasColumnType("int")
                .HasMaxLength(20);

            modelBuilder
              .HasIndex(t => t.EmployeeId);

            modelBuilder
                .Property(t => t.ReasonId)
                .HasColumnType("int")
                .HasMaxLength(20);

            modelBuilder
              .HasIndex(t => t.ReasonId);
        }
    }
}
