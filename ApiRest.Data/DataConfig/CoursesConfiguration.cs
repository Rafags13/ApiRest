using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiRest.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiRest.Data.DataConfig
{
    public class CoursesConfiguration : IEntityTypeConfiguration<Courses>
    {
        public void Configure(EntityTypeBuilder<Courses> builder)
        {
            builder.ToTable("Courses");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Title)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnType("varchar(500)")
                .IsRequired();

            builder.Property(x => x.Value)
                .HasColumnType("decimal(18,2)")
                .IsRequired();
        }
    }
}
