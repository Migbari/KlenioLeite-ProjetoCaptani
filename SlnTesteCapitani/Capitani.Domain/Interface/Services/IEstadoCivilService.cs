using Capitani.Domain.Entities;
using System.Collections.Generic;

namespace Capitani.Domain.Interface.Services
{
    public interface IEstadoCivilService : IServiceBase<EstadoCivilEntityViewModel>
    {
        IEnumerable<EstadoCivilEntityViewModel> GetByName(string name);
    }
}
