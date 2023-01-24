using ByteBankIO;
using System.Text;

partial class Program
{

    static void UsandoStreamDeEntrada()
    {


        using (var fluxoDeEntrada = Console.OpenStandardInput())
        using (var fs = new FileStream("entradasConsole.txt", FileMode.Create))
        {
            var buffer = new byte[1024];

            while (true)
            {
                var bytesLidos = fluxoDeEntrada.Read(buffer, 0, buffer.Length);
                fs.Write(buffer, 0, bytesLidos);
                fs.Flush();
                Console.WriteLine($"Bytes lidos na console: {bytesLidos}");
            }

        }
    }
}