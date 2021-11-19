using GlobalImpact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalImpact.ViewModels
{
    public class ClienteViewModel
    {
        public Cliente Cliente { get; set; }

        public IList<Cliente> Lista { get; set; }
    }
}
