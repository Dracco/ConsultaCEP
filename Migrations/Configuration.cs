namespace ConsultaCEP.Migrations
{
    using ConsultaCEP.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsultaCEP.Context.ViaCepContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ConsultaCEP.Context.ViaCepContext";
        }

        protected override void Seed(ConsultaCEP.Context.ViaCepContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
    
}
