using Capitani.Domain.Entities;
using System.Collections.Generic;

namespace Capitani.Domain.Interface.Application
{
    public interface IClienteApplication : IApplicationBase<Cliente>
    {
        IEnumerable<Cliente> GetByName(string name);
        IEnumerable<Cliente> GetByPartnerName(string name);
        void RemoveById(int id);
    }
}
