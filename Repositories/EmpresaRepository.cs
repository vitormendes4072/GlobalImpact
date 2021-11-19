using GlobalImpact.Controllers;
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
    public class EmpresaRepository : IEmpresaRepository
    {
        private ColheitaDoBemContext _context;
        public EmpresaRepository(ColheitaDoBemContext context)
        {
            _context = context;
        }

        public void Atualizar(Empresa empresa)
        {
            _context.Empresas.Update(empresa);
        }

        public IList<Empresa> BuscarPor(Expression<Func<Empresa, bool>> filtro)
        {
            return _context.Empresas.Where(filtro).Include(e => e.Endereco).ToList();
        }

        public Empresa BuscarPorId(int id)
        {
            return _context.Empresas.Where(e => e.EmpresaId == id).Include(e => e.Endereco).FirstOrDefault();
        }

        public void Cadastrar(Empresa empresa)
        {
            _context.Empresas.Add(empresa);
        }

        public IList<Empresa> Listar()
        {
            return _context.Empresas.Include(e => e.Endereco).ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            _context.Empresas.Remove(_context.Empresas.Find(id));
        }
    }
}
