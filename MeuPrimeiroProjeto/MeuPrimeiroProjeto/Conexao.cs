using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto
{
    internal class Conexao
    {
        private static CrmServiceClient crmServiceClientTrinamento; // variável do tipo CrmServiceCliente

        public CrmServiceClient ObterConexao() // método que devolve uma CrmServiceCliente
        {
            // variável contendo a ConnectionString
            var connectionStringCRM = @"AuthType=OAuth;
            Username = [user];
            Password = [Pass]; SkipDiscovery = True;
            AppId = [AppId];
            RedirectUri = [Uri];
            Url = [Url];";


            if (crmServiceClientTrinamento == null) // verifica se a variável crmServiceClientTrinamento está vazia
            {
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; // define o protocolo segurança
                crmServiceClientTrinamento = new CrmServiceClient(connectionStringCRM); // executa a conexão
            }
            return crmServiceClientTrinamento; // retorna a conexão para o método chamador
        }

    }
}
