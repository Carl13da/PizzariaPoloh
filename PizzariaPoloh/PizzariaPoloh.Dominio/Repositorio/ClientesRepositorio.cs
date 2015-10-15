using PizzariaPoloh.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPoloh.Dominio.Repositorio
{
    public class ClientesRepositorio
    {
        private readonly PizzariaPolohDBContext _context = new PizzariaPolohDBContext();
        public IEnumerable<Cliente> Clientes
        {
            get { return _context.Clientes; }
        }
    }
}
