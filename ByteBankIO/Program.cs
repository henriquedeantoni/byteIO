using ByteBankIO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        
        var caminhoNovoArquivo = "TextaEscrita.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))

        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write(false);
            escritor.Write(true);
            escritor.Write(45454545454545454);
        }
        Console.WriteLine("Aplicação Finalizada");

        Console.ReadLine();
    }
}

