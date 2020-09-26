using Capitani.Domain.Entities;
using System.Collections.Generic;

namespace Capitani.Domain.Interface.Repository
{
    public interface IClienteRepository : IRepositoryBase<ClienteEntityViewModel>
    {
        IEnumerable<ClienteEntityViewModel> GetByName(string name);
        IEnumerable<ClienteEntityViewModel> GetByPartnerName(string name);
        void RemoveById(int id);
    }
}
