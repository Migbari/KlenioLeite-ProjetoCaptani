using Capitani.Domain.Entities;
using System.Collections.Generic;

namespace Capitani.Domain.Interface.Application
{
    public interface IEstadoCivilApplication : IApplicationBase<EstadoCivilEntityViewModel>
    {
        IEnumerable<EstadoCivilEntityViewModel> GetByName(string name);
    }
}
