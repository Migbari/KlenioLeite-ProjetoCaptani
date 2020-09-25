using System.Collections.Generic;
using System.Threading.Tasks;

namespace Capitani.Domain.Interface.Services
{
    public interface IServiceBase<TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
