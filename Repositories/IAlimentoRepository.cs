using GlobalImpact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GlobalImpact.Repositories
{
    public interface IAlimentoRepository
    {
        void Cadastrar(Alimento alimento);
        void Salvar();
        IList<Alimento> Listar();
        Alimento BuscarPorId(int id);
        void Remover(int id);
        void Atualizar(Alimento alimento);

        IList<Alimento> BuscarPor(Expression<Func<Alimento, bool>> filtro);
    }
}
