using Capitani.Domain.Entities;
using Capitani.Domain.Interface.Application;
using Capitani.Domain.Interface.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitani.Application
{
    public class EstadoCivilApplication : ApplicationBase<EstadoCivilEntityViewModel>, IEstadoCivilApplication
    {
        private readonly IEstadoCivilService _estadoCivilService;
        public EstadoCivilApplication(IEstadoCivilService estadoCivilService)
            : base(estadoCivilService)
        {
            _estadoCivilService = estadoCivilService;
        }
        public IEnumerable<EstadoCivilEntityViewModel> GetByName(string name)
        {
            return _estadoCivilService.GetAll().ToList().Where(e => e.Descricao.Contains(name));
        }
    }
}
