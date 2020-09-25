using Capitani.Domain.Entities;
using System.Collections.Generic;

namespace Capitani.Domain.Interface.Application
{
    public interface IEstadoCivilApplication : IApplicationBase<EstadoCivil>
    {
        IEnumerable<EstadoCivil> GetByName(string name);
    }
}
