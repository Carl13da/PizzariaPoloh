using PizzariaPoloh.Dominio.Repositorio.Interfaces;
using System.Web.Mvc;

namespace PizzariaPoloh.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private IProdutoRepositorio _repositorio;

        public ProdutoController(IProdutoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public ActionResult Index()
        {
            var produtos = _repositorio.PegaProdutos();

            return View(produtos);
        }
    }
}