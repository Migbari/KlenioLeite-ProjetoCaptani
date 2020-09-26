using Capitani.Domain.Entities;
using Capitani.Domain.Interface.Repository;
using Capitani.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitani.Domain.Services
{
    public class ClienteService : ServiceBase<ClienteEntityViewModel>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<ClienteEntityViewModel> GetByName(string name)
        {
            return _clienteRepository.GetAll().ToList().Where(p => p.Nome.StartsWith(name));
        }

        public IEnumerable<ClienteEntityViewModel> GetByPartnerName(string name)
        {
            return _clienteRepository.GetAll().ToList().Where(p => p.NomeParceiro.StartsWith(name));
        }

        public void RemoveById(int id)
        {
            _clienteRepository.GetById(id).Ativo = false;
            _clienteRepository.GetById(id).DataInatividade = DateTime.Now;
        }
    }
}
