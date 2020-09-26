using Capitani.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capitani.Infra.Data.EntityTypeConfiguration
{
    public class EstadoCivilConfiguration : IEntityTypeConfiguration<EstadoCivilEntityViewModel>
    {
        public void Configure(EntityTypeBuilder<EstadoCivilEntityViewModel> builder)
        {
            builder.Property(e => e.Descricao)
               .IsRequired()
               .HasColumnType("Varchar(100)");
        }
    }
}
