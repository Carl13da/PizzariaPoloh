using System.Collections.Generic;

namespace PizzariaPoloh.Dominio.Entidades
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public Cliente Cliente { get; set; }
        public virtual ICollection<ItemPedido> Itens { get; set; }
    }
}
