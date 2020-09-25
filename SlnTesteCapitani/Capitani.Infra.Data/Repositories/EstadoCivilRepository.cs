using Capitani.Domain.Entities;
using Capitani.Domain.Interface.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Capitani.Infra.Data.Repositories
{
    public class EstadoCivilRepository : RepositoryBase<EstadoCivil>, IEstadoCivilRepository
    {
        public IEnumerable<EstadoCivil> GetByName(string name)
        {
            return Db.EstadoCivil.ToList().Where(e => e.Descricao.Contains(name));
        }
    }
}
