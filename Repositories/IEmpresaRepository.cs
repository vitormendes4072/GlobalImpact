using GlobalImpact.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GlobalImpact.Controllers
{
    public interface IEmpresaRepository
    {
        void Cadastrar(Empresa empresa);
        void Salvar();
        IList<Empresa> Listar();
        Empresa BuscarPorId(int id);
        void Remover(int id);
        void Atualizar(Empresa empresa);

        IList<Empresa> BuscarPor(Expression<Func<Empresa, bool>> filtro);
    }
}