using Capitani.Domain.Entities;
using System.Collections.Generic;

namespace Capitani.Domain.Interface.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> GetByName(string name);
        IEnumerable<Cliente> GetByPartnerName(string name);
        void RemoveById(int id);
    }
}
