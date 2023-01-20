using ByteBankIO;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var numeroDeBytesLidos = -1;
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);
        var buffer = new byte[1024]; //1KB

        // public override int Read(byte[] array, int offset, int count)
        // Devoluções:
        // O número total de bytes lidos do buffer. Isso poderá ser menor que o número de
        // bytes solicitado se esse número de bytes não estiver disponível no momento, ou
        // zero, se o final do fluxo for atingido

        while (numeroDeBytesLidos != 0)
        {
            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, buffer.Length);
            EscreverBuffer(buffer);
        }
                       
        Console.ReadLine();

    }

    static void EscreverBuffer(byte[] buffer)
    {
        var utf8 = new UTF8Encoding(); 
        var texto = utf8.GetString(buffer);
        Console.Write(texto);

        /*foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }
        */
    }
}