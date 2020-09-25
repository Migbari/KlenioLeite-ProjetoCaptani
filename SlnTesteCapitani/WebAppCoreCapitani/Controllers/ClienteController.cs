using Capitani.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WebAppCoreCapitani.Controllers
{
    public class ClienteController : Controller
    {
        //private readonly IMapper _mapper;
        //public ClienteController(IMapper mapper)
        //{
        //    _mapper = mapper;
        //}

        private async Task<IEnumerable<Cliente>> RetornarDados()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64829");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage resp = await client.GetAsync("/v1/Cliente");

            var dados = await resp.Content.ReadAsStringAsync();
            var verifica = JsonConvert.DeserializeObject<IEnumerable<Cliente>>(dados);
            return verifica;
        }

        // GET: ClienteController
        public Task<IEnumerable<Cliente>> Index()
        {
            return RetornarDados();

            // JsonConvert.DeserializeObject(); 

            //ViewBag.ListaEstadoCivil = _estadoCivilApplication.GetAll();

            //IEnumerable<Cliente> clientes = _clienteApplication.GetAll();
            //List<ClienteViewModel> clientesViewModel = new List<ClienteViewModel>();
            //foreach (Cliente cliente in clientes)
            //{
            //    ClienteViewModel clienteViewModel = new ClienteViewModel();
            //    clienteViewModel.Id = cliente.Id;
            //    clienteViewModel.Nome = cliente.Nome;
            //    clienteViewModel.EstadoCivilId = cliente.EstadoCivilId;
            //    clienteViewModel.EstadoCivil = cliente.EstadoCivil;
            //    clienteViewModel.DataNascimento = cliente.DataNascimento;
            //    clienteViewModel.NomeParceiro = cliente.NomeParceiro;
            //    clienteViewModel.DataNascimentoParceiro = cliente.DataNascimentoParceiro;
            //    clientesViewModel.Add(clienteViewModel);
            //}

            //return View(clientesViewModel);
            //return View(retorno);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
