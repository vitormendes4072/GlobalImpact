using GlobalImpact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalImpact.ViewModels
{
    public class AlimentoViewModel
    {
        public Alimento Alimento { get; set; }
        public IList<Alimento> Lista { get; set; }
    }
}
