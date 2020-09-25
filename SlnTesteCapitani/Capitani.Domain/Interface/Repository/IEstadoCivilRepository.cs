using Capitani.Domain.Entities;
using System.Collections.Generic;

namespace Capitani.Domain.Interface.Repository
{
    public interface IEstadoCivilRepository : IRepositoryBase<EstadoCivil>
    {
        IEnumerable<EstadoCivil> GetByName(string name);
    }
}
