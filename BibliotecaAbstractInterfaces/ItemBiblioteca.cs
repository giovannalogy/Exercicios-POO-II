using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAbstractInterfaces
{
    public abstract class ItemBiblioteca
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string  Editora { get; set; }
        public int Edicao { get; set; }
        public int Ano { get; set; }
        public int Paginas { get; set; }

        public bool EstaDisponivel { get; set; }
        public object Emprestar { get; internal set; }

        public ItemBiblioteca(string titulo, string autor, string editora, int edicao, int ano, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            Edicao = edicao;
            Ano = ano;
            Paginas = paginas;
            EstaDisponivel = true;
        }

        public interface IPodeSerEmprestado
        {
            void Emprestimo();
            void Devolucao();
        }

      

        //internal abstract void Devolucao();
        //internal abstract void Emprestimo();
    }
}

//continuar o exercício dado em aula para ser inteligente