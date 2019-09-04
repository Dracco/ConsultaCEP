namespace ConsultaCEP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddViaCepId : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ViaCepModels");
            AlterColumn("dbo.ViaCepModels", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ViaCepModels", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ViaCepModels");
            AlterColumn("dbo.ViaCepModels", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.ViaCepModels", "Id");
        }
    }
}
