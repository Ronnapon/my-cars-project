using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using my_cars.Data.Models;

namespace my_cars.EntityConfigurations
{
    public class ReasonConfiguration : EntityTypeConfiguration<Reason>
    {
        public override void Map(EntityTypeBuilder<Reason> modelBuilder)
        {
            modelBuilder
               .Property(t => t.Id)
               .HasColumnType("int")
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
        }
    }
}
