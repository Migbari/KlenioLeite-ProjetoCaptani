using Capitani.Domain.Entities;
using System.Data.Entity;

namespace Capitani.Domain.Interface.Repository
{
    public interface ICapitaniContext
    {
        DbSet<ClienteEntityViewModel> Cliente { get; set; }
        DbSet<EstadoCivilEntityViewModel> EstadoCivil { get; set; }
    }
}
