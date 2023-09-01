using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1_Abstract
{
    public class Empreiteira : Empresa
    {
        public Empreiteira(string NomeEmpresa, int NumeroDeFuncionarios) : base(NomeEmpresa, NumeroDeFuncionarios)
        {

        }

        public override void FazerVenda()
        {
            Console.WriteLine($"A Empreiteira {NomeEmpresa}, com {NumeroDeFuncionarios} funcionários, está anunciando uma nova construção.");
        }
    }
}
