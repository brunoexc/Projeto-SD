using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Descrição resumida de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Olá, Mundo";
        }

   
        public enum OperacoesBasicas
        {
            Adicao = 0,
            Divisao = 1,
            Multiplicacao = 2,
            Subtracao = 3
        }

        [WebMethod]
        public decimal Calculadora(decimal ValorA, decimal ValorB, OperacoesBasicas TipoOperacao)
        {
            decimal ResultadoAB = 0;
            switch (TipoOperacao)
            {
                case OperacoesBasicas.Adicao:
                    {
                        ResultadoAB = decimal.Add(ValorA, ValorB);
                        break;
                    }
                case OperacoesBasicas.Divisao:
                    {
                        ResultadoAB = decimal.Divide(ValorA, ValorB);
                        break;
                    }
                case OperacoesBasicas.Multiplicacao:
                    {
                        ResultadoAB = decimal.Multiply(ValorA, ValorB);
                        break;
                    }
                case OperacoesBasicas.Subtracao:
                    {
                        ResultadoAB = decimal.Subtract(ValorA, ValorB);
                        break;
                    }               

            }

            return ResultadoAB;
        }

    }
}
