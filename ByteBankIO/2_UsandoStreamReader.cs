using ByteBankIO;

partial class Program
{
    static void UsandoStreamReader()
    {
        var enderecoDoArquivo = "contas.txt";
        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDoArquivo);


            //var linha = leitor.ReadLine(); Le uma linha

            //var texto = leitor.ReadToEnd(); Le o Arquivo inteiro, carregando-o de uma única vez

            //var numero = leitor.Read(); Le apenas o primeiro caracter e mostra em "numero"(codificado)

            while (!leitor.EndOfStream) // EndOfStream para ler e exibir um arquivo até que o fluxo chegue ao fim
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha);
                Console.WriteLine(contaCorrente.ToString());
            }
        }
        Console.ReadLine();
    }
    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        // 375 4644 2483.13 Jonatan
        var campos = linha.Split(',');

        var agencia = int.Parse(campos[0]);
        var numero = int.Parse(campos[1]);
        var saldo = double.Parse(campos[2].Replace(".", ","));
        var nomeTitular = campos[3];

        var titular = new Cliente();
        titular.Nome = nomeTitular;

        var resultado = new ContaCorrente(agencia, numero);
        resultado.Depositar(saldo);
        resultado.Titular = titular;

        return resultado;
    }
}