using PizzariaPoloh.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPoloh.Dominio.Repositorio
{
    public class PedidoRepositorio
    {
        private readonly PizzariaPolohDBContext _context = new PizzariaPolohDBContext();
        public IEnumerable<Pedido> Pedidos
        {
            get { return _context.Pedidos; }
        }
        
    }
}
