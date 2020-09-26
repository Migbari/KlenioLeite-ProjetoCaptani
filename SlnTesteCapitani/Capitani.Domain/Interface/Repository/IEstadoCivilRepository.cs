using Capitani.Domain.Entities;
using System.Collections.Generic;

namespace Capitani.Domain.Interface.Repository
{
    public interface IEstadoCivilRepository : IRepositoryBase<EstadoCivilEntityViewModel>
    {
        IEnumerable<EstadoCivilEntityViewModel> GetByName(string name);
    }
}
