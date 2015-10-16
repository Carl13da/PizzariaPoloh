using System.Data.Entity;
using PizzariaPoloh.Dominio.Entidades;

namespace PizzariaPoloh.Dominio.Repositorio
{
    public class PizzariaPolohDBContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().ToTable("Produto");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Pedido>().ToTable("Pedido");
            modelBuilder.Entity<ItemPedido>().ToTable("ItemPedido");

            base.OnModelCreating(modelBuilder);
        }
    }
}
