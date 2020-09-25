using Capitani.Domain.Entities;
using Capitani.Domain.Interface.Application;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppAPICapitani.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class EstadoCivilController : ControllerBase
    {
        // GET: v1/<EstadoCivilController>
        [HttpGet]
        public IEnumerable<EstadoCivil> Get([FromServices] IEstadoCivilApplication estadoCivilApplication)
        {
            return estadoCivilApplication.GetAll();
        }

        // GET v1/<EstadoCivilController>/5
        [HttpGet("{id}")]
        public EstadoCivil Get(
            int id,
            [FromServices] IEstadoCivilApplication estadoCivilApplication)
        {
            return estadoCivilApplication.GetById(id);
        }

        // POST v1/<EstadoCivilController>
        [HttpPost]
        public ActionResult<EstadoCivil> Post(
            [FromServices] IEstadoCivilApplication estadoCivilApplication,
            [FromBody] EstadoCivil estadoCivilModel)
        {
            if (ModelState.IsValid)
            {
                estadoCivilApplication.Add(estadoCivilModel);
                return estadoCivilModel;
            }
            else
                return BadRequest(ModelState);
        }

        // PUT v1/<EstadoCivilController>/5
        [HttpPut("{id}")]
        public void Put(
            int id,
            [FromServices] IEstadoCivilApplication estadoCivilApplication,
            [FromBody] EstadoCivil estadoCivilModel)
        {
            estadoCivilApplication.Update(estadoCivilModel);
        }

        // DELETE v1/<EstadoCivilController>/5
        [HttpDelete("{id}")]
        public void Delete(
            int id,
            [FromServices] IEstadoCivilApplication estadoCivilApplication)
        {
            //Falta fazer o RemoveById para essa model.
            estadoCivilApplication.GetById(id);
        }
    }
}
