namespace TP3_04;

public class Program
{
    public static void Main(string[] args)
    {
        Ingresso ingresso = new Ingresso();

        ingresso.nomeDoShow = "Show da Banda";
        ingresso.preco = 50.00;
        ingresso.quantidadeDisponivel = 100;

        Console.WriteLine("Informações iniciais do ingresso:");
        ingresso.ExibirInformacoes();

        ingresso.AlterarPreco(75.00);
        ingresso.AlterarQuantidade(50);

        Console.WriteLine("\nInformações atualizadas do ingresso:");
        ingresso.ExibirInformacoes();
    }
}

public class Ingresso
{
    public string nomeDoShow;
    public double preco;
    public int quantidadeDisponivel;

    public void AlterarPreco(double novoPreco)
    {
        preco = novoPreco;
    }

    public void AlterarQuantidade(int novaQuantidade)
    {
        quantidadeDisponivel = novaQuantidade;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Show: {nomeDoShow}");
        Console.WriteLine($"Preço: R${preco}");
        Console.WriteLine($"Quantidade disponível: {quantidadeDisponivel}");
    }
}