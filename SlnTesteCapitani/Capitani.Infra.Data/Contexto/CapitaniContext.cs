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

        public DbSet<ClienteEntityViewModel> Cliente { get; set; }
        public DbSet<EstadoCivilEntityViewModel> EstadoCivil { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<ClienteEntityViewModel>(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration<EstadoCivilEntityViewModel>(new EstadoCivilConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-J1QGBRQ\\SQLEXPRESS;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DbCapitani;");
        }
    }
}
