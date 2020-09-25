using Capitani.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capitani.Infra.Data.EntityTypeConfiguration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.Property(e => e.Nome)
                .IsRequired()
                .HasColumnType("Varchar(100)");

            builder.Property(e => e.DataNascimento)
                .HasColumnType("DateTime");

            builder.Property(e => e.NomeParceiro)
                .HasColumnType("Varchar(100)");

            builder.Property(e => e.DataNascimentoParceiro)
                .HasColumnType("DateTime");

            builder.Property(e => e.Ativo)
                .IsRequired()
                .HasDefaultValueSql("1");

            builder.Property(e => e.DataInatividade)
                .HasColumnType("DateTime");
        }
    }
}
