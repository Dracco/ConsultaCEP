using ConsultaCEP.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
namespace ConsultaCEP.Context
{
    public class ViaCepContext : DbContext
    {

        public ViaCepContext()
           : base("name=Database")
        {
        }
        public DbSet<ViaCepModel> ViaCeps { get; set; }

        public void Save(ViaCepModel model)
        {
            try
            {
                using (var db = new ViaCepContext())
                {
                    var viacep = new ViaCepModel();
                    model.Id = Identity();
                    db.ViaCeps.Add(model);
                    db.SaveChanges();
                }
            }
            catch (System.Exception e)
            {

                throw;
            }
           
        }
        public List<ViaCepModel> Get()
        {
            using (var db = new ViaCepContext())
            {
               var query = (from v in db.ViaCeps
                             orderby v.DataHora descending
                             select v).Take(10);
                return query.ToList<ViaCepModel>();
            }
        }
        public int Identity()
        {
            using (var db = new ViaCepContext())
            {
                return (from v in db.ViaCeps
                             orderby v.Id descending
                             select v.Id + 1).FirstOrDefault();
            }
        }
    }
}