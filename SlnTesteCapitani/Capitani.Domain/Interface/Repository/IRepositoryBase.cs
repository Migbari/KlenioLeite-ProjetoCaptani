using System.Collections.Generic;

namespace Capitani.Domain.Interface.Repository
{
    public interface IRepositoryBase<TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
