using GlobalImpact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalImpact.ViewModels
{
    public class EmpresaViewModel
    {
        public Empresa Empresa { get; set; }
        public IList<Empresa> Lista { get; set; }
    }
}
