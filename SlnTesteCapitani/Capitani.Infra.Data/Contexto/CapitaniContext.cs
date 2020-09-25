using Capitani.Domain.Entities;
using Capitani.Domain.Interface.Repository;
using Capitani.Infra.Data.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Capitani.Infra.Data.Contexto
{
    public class CapitaniContext : DbContext
    {
        public CapitaniContext()
        { }
        public CapitaniContext(DbContextOptions<CapitaniContext> options)
        : base(options)
        {
            options = new DbContextOptions<CapitaniContext>();
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<EstadoCivil> EstadoCivil { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Cliente>(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration<EstadoCivil>(new EstadoCivilConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-J1QGBRQ\\SQLEXPRESS;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DbCapitani;");
        }
    }
}
