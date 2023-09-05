using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaAbstractInterfaces.ItemBiblioteca;

namespace BibliotecaAbstractInterfaces
{
    public class Biblioteca
    {
        private List<ItemBiblioteca> colecao = new List<ItemBiblioteca>();
        private List<ItemBiblioteca> itensDisponiveis = new List<ItemBiblioteca>();
        private List<ItemBiblioteca> itensEmprestados = new List<ItemBiblioteca>();
        private Dictionary<string, ItemBiblioteca> itens = new Dictionary<string, ItemBiblioteca>();
        private Dictionary<string, ItemBiblioteca> itensPorTitulo = new Dictionary<string, ItemBiblioteca>();

        //private List<ItemBiblioteca> itens = new List<ItemBiblioteca>();

        public Biblioteca()
        {
            itens = new Dictionary<string, ItemBiblioteca>();
        }
        public void AdicionarItem(ItemBiblioteca item)
        {
            itens[item.Titulo] = item;
        }

        public void EmprestarItem(string titulo)
        {
            if (itens.ContainsKey(titulo))
            {
                ItemBiblioteca item = itens[titulo];
                if (item.EstaDisponivel)
                {
                    
                    item.EstaDisponivel = false;
                    itensEmprestados.Add(item);
                    itensDisponiveis.Remove(item);
                    Console.WriteLine($"'{titulo}' emprestado com sucesso.");
                }
                else
                {
                    Console.WriteLine($"'{titulo}' não está disponível para empréstimo.");
                }
            }
            else
            {
                Console.WriteLine($"Item '{titulo}' não encontrado.");
            }
        }

        public void DevolverItem(string titulo)
        {
            if (itens.ContainsKey(titulo))
            {
                ItemBiblioteca item = itens[titulo];
                if (!item.EstaDisponivel)
                {
                    
                    item.EstaDisponivel = true;
                    itensEmprestados.Remove(item);
                    itensDisponiveis.Add(item);
                    Console.WriteLine($"'{titulo}' devolvido com sucesso.");
                }
                else
                {
                    Console.WriteLine($"'{titulo}' já está disponível.");
                }
            }
            else
            {
                Console.WriteLine($"Item '{titulo}' não encontrado.");
            }
        }

        public ItemBiblioteca PesquisarItemPorTitulo(string titulo)
        {
            foreach (var item in itens)
            {
                if (item.Value.Titulo == titulo)
                {
                    return item.Value;
                }
            }

            return null;
        }

    }
}
