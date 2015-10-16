namespace PizzariaPoloh.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuantidadeNoItemPedido : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemPedido", "Quantidade", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ItemPedido", "Quantidade");
        }
    }
}
