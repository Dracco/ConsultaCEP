namespace ConsultaCEP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ViaCepModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        DataHora = c.DateTime(nullable: false),
                        Complemento = c.String(maxLength: 200),
                        Logradouro = c.String(nullable: false, maxLength: 200),
                        Bairro = c.String(nullable: false, maxLength: 200),
                        Localidade = c.String(nullable: false, maxLength: 200),
                        Uf = c.String(nullable: false, maxLength: 2),
                        Cep = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ViaCepModels");
        }
    }
}
