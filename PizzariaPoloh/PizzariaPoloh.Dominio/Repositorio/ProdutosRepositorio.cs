using PizzariaPoloh.Dominio.Entidades;
using PizzariaPoloh.Dominio.Repositorio.Interfaces;
using System.Collections.Generic;

namespace PizzariaPoloh.Dominio.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly PizzariaPolohDBContext _context = new PizzariaPolohDBContext();

        public IEnumerable<Produto> PegaProdutos()
        {
            return _context.Produtos;
        }
    }
}
