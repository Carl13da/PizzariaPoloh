using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPoloh.Dominio.Entidades
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public string Cliente { get; set; }
        public string Produto { get; set; }
    }
}
