using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration;
internal class ActorConfiguration : IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> builder)
    {
        //Привязываемся к таблице
        //Задаем какое свойство будет являться PrimaryKey
        builder.ToTable(nameof(Actor))
               .HasKey(a => a.Id);

        builder.Property(a => a.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(a => a.Surname)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(a => a.PhoneNumber)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(a => a.DateOfBirth)
            .IsRequired();

        builder.Ignore(a => a.FullName);
    }
}
