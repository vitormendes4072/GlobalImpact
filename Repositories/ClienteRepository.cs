using GlobalImpact.Models;
using GlobalImpact.Persistences;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GlobalImpact.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private ColheitaDoBemContext _context;
        public ClienteRepository(ColheitaDoBemContext context)
        {
            _context = context;
        }

        public void Atualizar(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
        }

        public IList<Cliente> BuscarPor(Expression<Func<Cliente, bool>> filtro)
        {
            return _context.Clientes.Where(filtro).Include(e => e.Endereco).ToList();
        }

        public Cliente BuscarPorId(int id)
        {
            return _context.Clientes.Where(c => c.ClienteId == id).Include(e => e.Endereco).FirstOrDefault();
        }

        public void Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
        }

        public IList<Cliente> Listar()
        {
            return _context.Clientes.Include(e => e.Endereco).ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            _context.Clientes.Remove(_context.Clientes.Find(id));
        }
    }
}
