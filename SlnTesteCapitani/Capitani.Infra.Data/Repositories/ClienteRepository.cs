﻿using Capitani.Domain.Entities;
using Capitani.Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Capitani.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<ClienteEntityViewModel>, IClienteRepository
    {
        public IEnumerable<ClienteEntityViewModel> GetByName(string name)
        {
            return Db.Cliente.ToList().Where(e => e.Nome.Contains(name));
        }

        public IEnumerable<ClienteEntityViewModel> GetByPartnerName(string name)
        {
            return Db.Cliente.ToList().Where(e => e.NomeParceiro.Contains(name));
        }

        public void RemoveById(int id)
        {
            Db.Cliente.Find(id).Ativo = false;
            Db.Cliente.Find(id).DataInatividade = DateTime.Now;
            Db.SaveChanges();
        }
    }
}
