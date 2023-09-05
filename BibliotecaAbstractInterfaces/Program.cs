using BibliotecaAbstractInterfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();
        

        Revista revista = new Revista("Mundo Estranho", "Vários autores", "Editora Abril", 150 , 2023, 60);
        MidiaDigital midiadigital = new MidiaDigital("E-book Organizando Rotina", "João Silva", "Editora Arqueiro", 2, 2021, 300);
        Livro livro = new Livro("Morro dos Ventos Uivantes", "Emily Bronte", "Editora Sextante", 10, 2011, 255);

        biblioteca.AdicionarItem(revista);
        biblioteca.AdicionarItem(midiadigital);
        biblioteca.AdicionarItem(livro);

       
        int opcao = 0;

        do
        {
            Console.WriteLine("Menu da Biblioteca:");
            Console.WriteLine("1. Empréstimo de Item");
            Console.WriteLine("2. Devolução de Item");
            Console.WriteLine("3. Pesquisar Item");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.WriteLine("Informe o título do item a ser emprestado:");
                    string tituloEmprestar = Console.ReadLine();
                    biblioteca.EmprestarItem(tituloEmprestar);
                    break;
                case "2":
                    Console.WriteLine("Informe o título do item a ser devolvido:");
                    string tituloDevolver = Console.ReadLine();
                    biblioteca.DevolverItem(tituloDevolver);
                    break;
                case "3":
                    Console.WriteLine("Informe o título do item a ser pesquisado:");
                    string tituloPesquisar = Console.ReadLine();
                    ItemBiblioteca itemPesquisar = biblioteca.PesquisarItemPorTitulo(tituloPesquisar);
                    if (itemPesquisar != null)
                    {
                        Console.WriteLine($"Item encontrado: {itemPesquisar.Titulo}");
                    }
                    else
                    {
                        Console.WriteLine("Item não encontrado.");
                    }
                    break;
                case "4":
                    opcao = 4;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
       
        } while (opcao != 4);
        
        Console.ReadKey();

        biblioteca.AdicionarItem(revista);
        biblioteca.AdicionarItem(midiadigital);
        biblioteca.AdicionarItem(livro);

        biblioteca.EmprestarItem("Mundo Estranho");
        biblioteca.EmprestarItem("E-book Organizando Rotina");
        biblioteca.EmprestarItem("Morro dos Ventos Uivantes");

        biblioteca.DevolverItem("Mundo Estranho");
        biblioteca.DevolverItem("E-book Organizando Rotina");
        biblioteca.DevolverItem("Morro dos Ventos Uivantes");

        biblioteca.PesquisarItemPorTitulo("Mundo Estranho");
        biblioteca.PesquisarItemPorTitulo("E-book Organizando Rotina");
        biblioteca.PesquisarItemPorTitulo("Morro dos Ventos Uivantes");
    }
}