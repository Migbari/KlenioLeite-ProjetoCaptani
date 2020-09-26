using Capitani.Domain.Entities;
using System.Collections.Generic;

namespace Capitani.Domain.Interface.Services
{
    public interface IClienteService : IServiceBase<ClienteEntityViewModel>
    {
        IEnumerable<ClienteEntityViewModel> GetByName(string name);
        IEnumerable<ClienteEntityViewModel> GetByPartnerName(string name);
        void RemoveById(int id);
    }
}
