using Exercício1_Abstract;

//Crie uma classe Empresa que possua os dados básicos de uma empresa como propriedades.
//Construa um método para imprimir as informações da empresa.
//Construa um método abstrato void RealizarVenda()

//Crie uma classe Varejo que implemente o método abstrato para imprimir que vende produtos.
//Crie uma classe Empreiteira que implemente o método abstrato para imprimir que vende serviços.

//Na main, crie um objeto de cada classe, preenchendo as propriedades e invocando os métodos
internal class Program
{
    private static void Main(string[] args)
    {
        //Empresa empresa = new Empresa("Grupo XYZ", 100);
        Varejo varejo = new Varejo("Loja XYZ", 30);
        Empreiteira empreiteira = new Empreiteira("Construtora XYZ", 50);

        Console.WriteLine("\nInformações da Loja XYZ");
        varejo.ImprimirDados();
        varejo.FazerVenda();

        Console.WriteLine("\nInformações da Construtora XYZ");
        empreiteira.ImprimirDados();
        empreiteira.FazerVenda();
    }
}