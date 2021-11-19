using GlobalImpact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GlobalImpact.Repositories
{
    public interface IClienteRepository
    {
        void Cadastrar(Cliente cliente);
        void Salvar();
        IList<Cliente> Listar();
        Cliente BuscarPorId(int id);
        void Remover(int id);
        void Atualizar(Cliente cliente);

        IList<Cliente> BuscarPor(Expression<Func<Cliente, bool>> filtro);
    }
}
