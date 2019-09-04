using ConsultaCEP.Models;
using Core.App.Site.Lib;
using System;

namespace ConsultaCEP.API
{
    public class ViaCep
    {
        public ViaCepModel viaCep { get; set; }
        public ViaCep(string cep)
        {
            viaCep = new ViaCepModel();
            viaCep = Util.GetJsonAndDeserialize<ViaCepModel>("https://viacep.com.br/ws/CEP/json/".Replace("CEP", cep.Replace(".", "").Replace("-", "")));
            viaCep.DataHora = DateTime.Now;
        }
    }
}