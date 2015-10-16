namespace PizzariaPoloh.Dominio.Migrations
{
    using Entidades;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Repositorio.PizzariaPolohDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PizzariaPoloh.Dominio.Repositorio.PizzariaPolohDBContext";
        }

        protected override void Seed(Repositorio.PizzariaPolohDBContext context)
        {
            context.Produtos.AddOrUpdate(
                p => p.Nome,
                new Produto { Nome = "Frango c/ Catupiry", Preco = 25.50m },
                new Produto { Nome = "Muçarela", Preco = 18 },
                new Produto { Nome = "Calabresa", Preco = 21.50m },
                new Produto { Nome = "Marguerita", Preco = 24.30m },
                new Produto { Nome = "Especial Poloh", Preco = 30m }
            );

            context.Clientes.AddOrUpdate(
                p => p.Email,
                new Cliente { Nome = "Carlos", Email = "carlos@gmail.com", Endereco = "Rua Não sei, 209" },
                new Cliente { Nome = "Carlos Afonso", Email = "carlosafonso@gmail.com", Endereco = "Rua algumacoisa, 300" },
                new Cliente { Nome = "Luna", Email = "luna@gmail.com", Endereco = "Rua Kobe 1005" }
            );
        }
    }
}
