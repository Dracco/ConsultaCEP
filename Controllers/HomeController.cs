using Newtonsoft.Json;
using System.Web.Mvc;


namespace ConsultaCEP.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public string Index(string cep)
        {
            try
            {
                API.ViaCep endereco = new API.ViaCep(cep);

                SalvaEndereco(endereco.viaCep);

                return RecuperaHistorico();
            }
            catch
            {
                return "Não foi possível consultar o CEP informado. Por favor verifique se o CEP está correto.";
            }
        }

        private void SalvaEndereco(Models.ViaCepModel endereco)
        {
            Context.ViaCepContext context = new Context.ViaCepContext();

            //salvar no banco
            context.Save(endereco);
        }
        private string RecuperaHistorico()
        {
            Context.ViaCepContext context = new Context.ViaCepContext();

            //recuperar os dados
            var retorno = context.Get();
            var settings = new JsonSerializerSettings { DateFormatString = "dd-MM-yyyy HH:mm:ss" };
            var json = JsonConvert.SerializeObject(retorno, settings);

            return (json);
        }
    }
}