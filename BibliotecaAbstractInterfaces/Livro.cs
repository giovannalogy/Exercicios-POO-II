using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaAbstractInterfaces.ItemBiblioteca;

namespace BibliotecaAbstractInterfaces
{
    internal class Livro : ItemBiblioteca, IPodeSerEmprestado
    {
        public bool Emprestado { get; set; }

        public Livro(string titulo, string autor, string editora, int edicao, int ano, int paginas) : base (titulo, autor, editora, edicao, ano, paginas)
        {
            Emprestado = true;
        }

        public void Emprestimo()
        {
            if (!EstaDisponivel)
            {
                Emprestado = true;
                Console.WriteLine($"Empréstimo do Livro '{Titulo}' foi realizado com sucesso");
            }
            else
            {
                Console.WriteLine($"Infelizmente, o livro '{Titulo}' já foi emprestado");
            }
        }

        public void Devolucao()
        {
            if (!EstaDisponivel)
            {
                EstaDisponivel = true;
                Console.WriteLine($"A Devolução do livro '{Titulo}' foi realizada com sucesso.");
            }

            else
            {
                Console.WriteLine($"O livro '{Titulo}' está disponível.");
            }
        }

    }
}
