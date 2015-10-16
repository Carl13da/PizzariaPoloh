using PizzariaPoloh.Dominio.Entidades;
using System.Collections.Generic;

namespace PizzariaPoloh.Dominio.Repositorio.Interfaces
{
    public interface IProdutoRepositorio
    {
        IEnumerable<Produto> PegaProdutos();
    }
}
