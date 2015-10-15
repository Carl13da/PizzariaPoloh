using PizzariaPoloh.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPoloh.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly PizzariaPolohDBContext _context = new PizzariaPolohDBContext();
        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos;  }
        }
        

    }
}
