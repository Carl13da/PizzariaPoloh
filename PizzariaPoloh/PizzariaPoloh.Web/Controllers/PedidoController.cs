using PizzariaPoloh.Web.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PizzariaPoloh.Web.Controllers
{
    public class PedidoController : Controller
    {
        // GET: Pedido
        [HttpPost]
        public ActionResult Finalizar(List<ItemPedidoViewModel> pedido)
        {
            return View(pedido);
        }
    }
}