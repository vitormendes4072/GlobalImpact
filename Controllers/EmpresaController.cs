using GlobalImpact.Models;
using GlobalImpact.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalImpact.Controllers
{
    public class EmpresaController : Controller
    {
        private IEmpresaRepository _empresaRepository;

        public EmpresaController(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
        public IActionResult Index(string nomeBusca)
        {
            var lista = _empresaRepository.BuscarPor(e =>
                (e.Nome.Contains(nomeBusca) || nomeBusca == null));
            //Envia a lista de musicas para a view
            return View(lista);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Empresa empresa)
        {
            _empresaRepository.Cadastrar(empresa);
            _empresaRepository.Salvar();
            TempData["msg"] = "Empresa cadastrada";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            _empresaRepository.Remover(id);
            _empresaRepository.Salvar();
            TempData["msg"] = "Empresa removida!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var empresa = _empresaRepository.BuscarPorId(id);
            return View(empresa);
        }

        [HttpPost]
        public IActionResult Editar(Empresa empresa)
        {
            _empresaRepository.Atualizar(empresa);
            _empresaRepository.Salvar();
            TempData["msg"] = "Empresa atualizada!";
            return RedirectToAction("Index");
        }
    }
}
