using Capitani.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capitani.Infra.Data.EntityTypeConfiguration
{
    public class EstadoCivilConfiguration : IEntityTypeConfiguration<EstadoCivil>
    {
        public void Configure(EntityTypeBuilder<EstadoCivil> builder)
        {
            builder.Property(e => e.Descricao)
               .IsRequired()
               .HasColumnType("Varchar(100)");
        }
    }
}
