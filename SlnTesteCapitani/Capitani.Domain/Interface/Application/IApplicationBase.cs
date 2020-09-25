using System.Collections.Generic;

namespace Capitani.Domain.Interface.Application
{
    public interface IApplicationBase<TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
