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
    public class AlimentoRepository : IAlimentoRepository
    {
        private ColheitaDoBemContext _context;
        public AlimentoRepository(ColheitaDoBemContext context)
        {
            _context = context;
        }

        public void Atualizar(Alimento alimento)
        {
            _context.Alimentos.Update(alimento);
        }

        public IList<Alimento> BuscarPor(Expression<Func<Alimento, bool>> filtro)
        {
            return _context.Alimentos.Where(filtro).Include(a => a.Empresa).ToList();
        }

        public Alimento BuscarPorId(int id)
        {
            return _context.Alimentos.Where(a => a.AlimentoId == id).Include(a => a.Empresa).FirstOrDefault();
        }

        public void Cadastrar(Alimento alimento)
        {
            _context.Alimentos.Add(alimento);
        }

        public IList<Alimento> Listar()
        {
            return _context.Alimentos.Include(e => e.Empresa).ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            _context.Alimentos.Remove(_context.Alimentos.Find(id));
        }
    }
}
