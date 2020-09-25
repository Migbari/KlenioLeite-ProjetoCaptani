using Capitani.Domain.Entities;
using Capitani.Domain.Interface.Application;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppAPICapitani.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        // GET: v1/<ClienteController>
        [HttpGet]
        public IEnumerable<Cliente> Get([FromServices] IClienteApplication clienteApplication)
        {
            return clienteApplication.GetAll();
        }

        [HttpGet]
        [Route("/GetByName")]
        public IEnumerable<Cliente> GetByName(
            string nome,
            int posicaoInicioPagina,
            int linhasPagina,
            [FromServices] IClienteApplication clienteApplication)
        {
            return clienteApplication.GetByName(nome).ToList().Skip(posicaoInicioPagina).Take(linhasPagina);
        }

        // GET v1/<ClienteController>/5
        [HttpGet("{id}")]
        [Route("/GetById")]
        public Cliente Get(
            int id, 
            [FromServices]IClienteApplication clienteApplication)
        {
            return clienteApplication.GetById(id);
        }

        // POST v1/<ClienteController>
        [HttpPost]
        public ActionResult<Cliente> Post(
            [FromServices] IClienteApplication clienteApplication,
            [FromBody]Cliente clienteModel)
        {
            bool isValidParceiroCasado = clienteModel.IsValidParceiroCasado(clienteModel);
            
            if (ModelState.IsValid && isValidParceiroCasado)
            {
                clienteApplication.Add(clienteModel);
                return clienteModel;
            }
            else
            {
                if (isValidParceiroCasado)
                    return BadRequest(ModelState);
                else
                {
                    string msgBadRequest = "";
                    if (!string.IsNullOrEmpty(clienteModel.NomeParceiro)
                        && (clienteModel.DataNascimentoParceiro != null
                        && clienteModel.DataNascimentoParceiro != DateTime.MinValue))
                        msgBadRequest = "O Nome e a Data de Nascimento do Parceiro não podem ser informados, pois o cliente não é casado.";
                    else
                        msgBadRequest = (!string.IsNullOrEmpty(clienteModel.NomeParceiro)) 
                        ? "O Nome do Parceiro não pode ser informado, pois o cliente não é casado." : 
                          "A Data de Nascimento do Parceiro não pode ser informada, pois o cliente não é casado.";
                    
                    return BadRequest(msgBadRequest);
                }
            }
        }

        // PUT v1/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(
            int id,
            [FromServices] IClienteApplication clienteApplication,
            [FromBody] Cliente clienteModel)
        {
            clienteApplication.Update(clienteModel);
        }

        // DELETE v1/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(
            int id,
            [FromServices] IClienteApplication clienteApplication)
        {
            clienteApplication.RemoveById(id);
        }
    }
}
