using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var numeroDeBytesLidos = -1;

        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        var buffer = new byte[1024]; 

        
        
        while(numeroDeBytesLidos !=0)
        {
            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
            EscreverBuffer(buffer);
        }

        fluxoDoArquivo.Read(buffer, 0, buffer.Length);
;  
        Console.ReadLine();
    }

    static void EscreverBuffer(byte[] buffer )
    {
        foreach( var myByte in buffer)
        {
            Console.Write(myByte);
            Console.Write(" ");
        }
    }
}