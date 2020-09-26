using Capitani.Domain.Entities;
using Capitani.Domain.Interface.Repository;
using Capitani.Domain.Interface.Services;
using System.Collections.Generic;
using System.Linq;

namespace Capitani.Domain.Services
{
    public class EstadoCivilService : ServiceBase<EstadoCivilEntityViewModel>, IEstadoCivilService
    {
        private readonly IEstadoCivilRepository _estadoCivilRepository;
        public EstadoCivilService(IEstadoCivilRepository estadoCivilRepository)
            : base(estadoCivilRepository)
        {
            _estadoCivilRepository = estadoCivilRepository;
        }

        public IEnumerable<EstadoCivilEntityViewModel> GetByName(string name)
        {
            return _estadoCivilRepository.GetAll().ToList().Where(e => e.Descricao.Contains(name));
        }
    }
}
