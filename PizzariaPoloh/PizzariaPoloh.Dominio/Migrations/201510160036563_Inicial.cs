namespace PizzariaPoloh.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Endereco = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        PedidoId = c.Int(nullable: false, identity: true),
                        Cliente_ClienteId = c.Int(),
                    })
                .PrimaryKey(t => t.PedidoId)
                .ForeignKey("dbo.Cliente", t => t.Cliente_ClienteId)
                .Index(t => t.Cliente_ClienteId);
            
            CreateTable(
                "dbo.ItemPedido",
                c => new
                    {
                        ItemPedidoId = c.Int(nullable: false, identity: true),
                        Pedido_PedidoId = c.Int(),
                        Produto_ProdutoId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemPedidoId)
                .ForeignKey("dbo.Pedido", t => t.Pedido_PedidoId)
                .ForeignKey("dbo.Produto", t => t.Produto_ProdutoId)
                .Index(t => t.Pedido_PedidoId)
                .Index(t => t.Produto_ProdutoId);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProdutoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemPedido", "Produto_ProdutoId", "dbo.Produto");
            DropForeignKey("dbo.ItemPedido", "Pedido_PedidoId", "dbo.Pedido");
            DropForeignKey("dbo.Pedido", "Cliente_ClienteId", "dbo.Cliente");
            DropIndex("dbo.ItemPedido", new[] { "Produto_ProdutoId" });
            DropIndex("dbo.ItemPedido", new[] { "Pedido_PedidoId" });
            DropIndex("dbo.Pedido", new[] { "Cliente_ClienteId" });
            DropTable("dbo.Produto");
            DropTable("dbo.ItemPedido");
            DropTable("dbo.Pedido");
            DropTable("dbo.Cliente");
        }
    }
}
