using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaAbstractInterfaces.ItemBiblioteca;

namespace BibliotecaAbstractInterfaces
{
    internal class MidiaDigital : ItemBiblioteca , IPodeSerEmprestado
    {
        public bool Emprestado { get; set; }

        public MidiaDigital(string titulo, string autor, string editora, int edicao, int ano, int paginas) : base(titulo, autor, editora, edicao, ano, paginas)
        {
            Emprestado = true;
        }

        public void Emprestimo()
        {
            if (!EstaDisponivel)
            {
                Emprestado = true;
                Console.WriteLine($"Empréstimo da mídia '{Titulo}' foi realizado com sucesso");
            }
            else
            {
                Console.WriteLine($"Infelizmente a mídia '{Titulo}' já foi emprestada");
            }
        }

        public void Devolucao()
        {
            if (!EstaDisponivel)
            {
                EstaDisponivel = true;
                Console.WriteLine($"A Devolução da mídia '{Titulo}' foi realizada com sucesso.");
            }

            else
            {
                Console.WriteLine($"Á mídia '{Titulo}' está disponível.");
            }
        }
    }
}
