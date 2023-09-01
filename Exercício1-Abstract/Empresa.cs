using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1_Abstract
{
    public abstract class Empresa
    {
        public string NomeEmpresa { get; set; }
        public int NumeroDeFuncionarios { get; set; }

        public Empresa(string nomeEmpresa, int numeroDeFuncionarios)
        {
            NomeEmpresa = nomeEmpresa;
            NumeroDeFuncionarios = numeroDeFuncionarios;
        }

        public void ImprimirDados()
        {
           Console.WriteLine($"Nome:{NomeEmpresa}");
           Console.WriteLine($"Número de Funcionários:{NumeroDeFuncionarios}");
        }

        public abstract void FazerVenda();
    }

    
}
