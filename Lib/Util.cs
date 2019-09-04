using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace Core.App.Site.Lib
{
    public class Util
    {
        public static T GetJsonAndDeserialize<T>(string endereco)
        {
            T obj = Activator.CreateInstance<T>();


            var requisicaoWeb = WebRequest.Create(endereco);
            requisicaoWeb.Timeout = 5000;
            requisicaoWeb.Method = "GET";
            requisicaoWeb.ContentType = "text/json";


            try
            {
                //ler e exibir a resposta
                using (var resposta = requisicaoWeb.GetResponse())
                {
                    var streamDados = resposta.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object objResponse = reader.ReadToEnd();
                    obj = JsonConvert.DeserializeObject<T>(objResponse.ToString());
                    streamDados.Close();
                    resposta.Close();
                }
                return obj;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




    }
}

