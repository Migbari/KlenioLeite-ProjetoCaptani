using Capitani.Domain.Entities;
using System.Collections.Generic;

namespace Capitani.Domain.Interface.Repository
{
    public interface IClienteRepository : IRepositoryBase<Cliente>
    {
        IEnumerable<Cliente> GetByName(string name);
        IEnumerable<Cliente> GetByPartnerName(string name);
        void RemoveById(int id);
    }
}
