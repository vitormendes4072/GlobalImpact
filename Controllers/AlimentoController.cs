using GlobalImpact.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalImpact.Controllers
{
    public class AlimentoController : Controller
    {
        private IAlimentoRepository _alimentoRepository;

        public AlimentoController(IAlimentoRepository alimentoRepository)
        {
            _alimentoRepository = alimentoRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
