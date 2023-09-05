using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaAbstractInterfaces.ItemBiblioteca;

namespace BibliotecaAbstractInterfaces
{
    internal class Revista : ItemBiblioteca , IPodeSerEmprestado
    {
        public bool Emprestado { get; set; }

        public Revista(string titulo, string autor, string editora, int edicao, int ano, int paginas) : base(titulo, autor, editora, edicao, ano, paginas)
        {
            Emprestado = true;
        }

        public void Emprestimo()
        {
            if (!EstaDisponivel)
            {
                Emprestado = true;
                Console.WriteLine($"Empréstimo da revista '{Titulo}' foi realizado com sucesso");
            }
            else
            {
                Console.WriteLine($"Infelizmente a revista '{Titulo}' já foi emprestada");
            }
        }

        public void Devolucao()
        {
            if (!EstaDisponivel)
            {
                EstaDisponivel = true;
                Console.WriteLine($"A Devolução da revista '{Titulo}' foi realizada com sucesso.");
            }

            else
            {
                Console.WriteLine($"A revista '{Titulo}' está disponível.");
            }
        }

    }
}
