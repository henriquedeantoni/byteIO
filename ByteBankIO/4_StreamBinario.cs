using ByteBankIO;
using System.Text;

partial class Program
{
    static void EscritaBinaria()
    {

        using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
        using (var escritor = new BinaryWriter(fs))
        {
            escritor.Write(456);
            escritor.Write(456544);
            escritor.Write(4000.50);
            escritor.Write("Gustavo Braga");

        }
    }

    static void LeituraBinaria()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
        using (var escritor = new BinaryWriter(fs))
        {
            va
        }
    }
}

