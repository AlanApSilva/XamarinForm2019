using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App1.Servico.Modelo;
using Newtonsoft.Json;

namespace App1.Servico
{
    public class ViaCepServico
    {
        private static string url = @"https://viacep.com.br/ws/{0}/json/";


        public static Endereco BuscaEnderecoCep(string cep)
        {
            string novoend = string.Format(url, cep);

            WebClient wc = new WebClient();
            var conteudo = wc.DownloadString(novoend);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo);

            return end;
        }
    }
}
