using ByteBankIO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Digite seu nome:");
        //var nome = Console.ReadLine();
        
        var linhas = File.ReadAllText("contas.txt");
        Console.WriteLine(linhas.Length);

        /*
        foreach (var linha in linhas)
        {
            Console.WriteLine(linha);
        }
        */

        var bytesArquivo = File.ReadAllBytes("contas.txt");
        Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

        File.WriteAllText("escrevendoComClasseFile.txt", "Testando File.WriteAllText");


        Console.WriteLine("Aplicação Finalizada ...");

        Console.ReadLine();
            
    }
}

/*
    Todos os métodos que estudamos facilitam nosso trabalho ao lidar com arquivos, 
    porém é essencial ter certos cuidados. Se quiséssemos ler todo o texto de um documento, 
    por exemplo, uma opção seria o método ReadAllText. 
    Ele retorna uma string com todo o conteúdo de um arquivo, 
    porém essa prática vai contra o objetivo de não ler arquivos de uma única vez, 
    especialmente se forem grandes. Para arquivos pequenos, esse método é uma boa opção.

    É importante avaliar cada contexto para optar pela melhor estratégia. 
    Haverá casos em que será mais interessante ter um controle mais preciso do buffer e das posições ocupadas nele, por exemplo. 
    Por isso, é importante entendermos o funcionamento dessas classes e desses métodos.
*/
