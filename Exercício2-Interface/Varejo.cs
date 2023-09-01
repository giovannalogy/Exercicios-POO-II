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

        public Varejo(string nomeEmpresa, int numeroDeFuncionarios)
        {
            NomeEmpresa = nomeEmpresa;
            NumeroDeFuncionarios = numeroDeFuncionarios;
        }

        public void ImprimirDados()
        {
            Console.WriteLine($"Nome:{NomeEmpresa}");
            Console.WriteLine($"Número de Funcionários:{NumeroDeFuncionarios}");
        }

        public void FazerVenda()
        {
            Console.WriteLine("O Varejo vendeu muitos notebooks!");

        }

    }
}
