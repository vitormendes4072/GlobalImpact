using GlobalImpact.Models;
using GlobalImpact.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalImpact.Controllers
{
    public class ClienteController : Controller
    {
        private IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IActionResult Index(string nomeBusca, Genero? generoBusca)
        {
            var lista = _clienteRepository.BuscarPor(c =>
                (c.Nome.Contains(nomeBusca) || nomeBusca == null) &&
                (c.Genero == generoBusca || generoBusca == null));
            return View(lista);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Cliente cliente)
        {
            _clienteRepository.Cadastrar(cliente);
            _clienteRepository.Salvar();
            TempData["msg"] = "Cliente cadastrado!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            _clienteRepository.Remover(id);
            _clienteRepository.Salvar();
            TempData["msg"] = "Cliente removido!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var cliente = _clienteRepository.BuscarPorId(id);
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Editar(Cliente cliente)
        {
            _clienteRepository.Atualizar(cliente);
            _clienteRepository.Salvar();
            TempData["msg"] = "Cliente atualizado!";
            return RedirectToAction("Index");
        }
    }
}
