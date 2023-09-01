using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1_Abstract
{
    public class Varejo : Empresa
    {
        public Varejo(string NomeEmpresa, int NumeroDeFuncionarios) : base(NomeEmpresa, NumeroDeFuncionarios)
        {

        }

        public override void FazerVenda()
        {
            Console.WriteLine($"O Varejo {NomeEmpresa}, com {NumeroDeFuncionarios} funcionários, está anunciando venda de notebook");
        }
    }
}
