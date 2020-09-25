using Capitani.Domain.Entities;
using System.Collections.Generic;

namespace Capitani.Domain.Interface.Services
{
    public interface IEstadoCivilService : IServiceBase<EstadoCivil>
    {
        IEnumerable<EstadoCivil> GetByName(string name);
    }
}
