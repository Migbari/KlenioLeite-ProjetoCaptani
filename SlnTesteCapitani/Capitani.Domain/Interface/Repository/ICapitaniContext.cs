using Capitani.Domain.Entities;
using System.Data.Entity;

namespace Capitani.Domain.Interface.Repository
{
    public interface ICapitaniContext
    {
        DbSet<Cliente> Cliente { get; set; }
        DbSet<EstadoCivil> EstadoCivil { get; set; }
    }
}
