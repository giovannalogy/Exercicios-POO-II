using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2_Interface
{
    public interface IImplementacao
    {
        public string NomeEmpresa { get; set; }
        public int NumeroDeFuncionarios { get; set; }

        public void ImprimirDados();
    }

    public interface IVenda
    {
        void FazerVenda();
    }

}
