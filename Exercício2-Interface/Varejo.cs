using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2_Interface
{
    public class Varejo: IImplementacao, IVenda
    {
        public string NomeEmpresa { get; set; }
        public int NumeroDeFuncionarios { get; set; }

        private readonly IEnviarNotificação enviarNotificação;

        public Varejo(string nomeEmpresa, int numeroDeFuncionarios, IEnviarNotificação enviarNotificação)
        {
            NomeEmpresa = nomeEmpresa;
            NumeroDeFuncionarios = numeroDeFuncionarios;
            this.enviarNotificação = enviarNotificação;
        }

        public void ImprimirDados()
        {
            Console.WriteLine($"Nome:{NomeEmpresa}");
            Console.WriteLine($"Número de Funcionários:{NumeroDeFuncionarios}");
        }

        public void FazerVenda()
        {
            Console.WriteLine("O Varejo vendeu um notebook");

            enviarNotificação.EnviarMensagemCliente();


        }

    }
}
