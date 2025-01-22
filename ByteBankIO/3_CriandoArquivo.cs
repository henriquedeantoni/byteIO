using ByteBankIO;
using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "ContasExportadas.csv";
        
        using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7865, 4785.40, Gustavo Santos";

            var enconding = Encoding.UTF8;

            var bytes = enconding.GetBytes(contaComoString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        }

    }
}