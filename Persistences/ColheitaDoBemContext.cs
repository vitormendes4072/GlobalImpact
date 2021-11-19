using GlobalImpact.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalImpact.Persistences
{
    public class ColheitaDoBemContext : DbContext
    {
        public ColheitaDoBemContext(DbContextOptions options) : base(options) { }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Alimento> Alimentos { get; set; }
    }
}
