using Capitani.Domain.Entities;
using Capitani.Domain.Interface.Application;
using Capitani.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Capitani.Application
{
    public class ClienteApplication : ApplicationBase<Cliente>, IClienteApplication
    {
        private readonly IClienteService _clienteService;
        public ClienteApplication(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }
        public IEnumerable<Cliente> GetByName(string name)
        {
            return _clienteService.GetAll().ToList().Where(e => e.Nome.Contains(name));
        }
        public IEnumerable<Cliente> GetByPartnerName(string name)
        {
            return _clienteService.GetAll().ToList().Where(e => e.NomeParceiro.Contains(name));
        }
        public void RemoveById(int id)
        {
            _clienteService.GetById(id).Ativo = false;
            _clienteService.GetById(id).DataInatividade = DateTime.Now;
        }
    }
}
