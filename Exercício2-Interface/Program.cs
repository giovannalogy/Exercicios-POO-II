using Exercício2_Interface;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IVenda> vendas = new List<IVenda>();

        List<IImplementacao> empresas = new List<IImplementacao>();

        EnviarNotificacaoWhatsapp notificacaoWhatsapp = new EnviarNotificacaoWhatsapp();

        empresas.Add(new Empresa("Grupo XYZ", 150));
        empresas.Add(new Varejo("Loja XYZ", 30, notificacaoWhatsapp));
        empresas.Add(new Empreiteira("Empreiteira XYZ", 100));

        foreach (var empresa in empresas)
        {
            empresa.ImprimirDados();
            ((IVenda)empresa).FazerVenda();
            Console.WriteLine();
        }
    }
}