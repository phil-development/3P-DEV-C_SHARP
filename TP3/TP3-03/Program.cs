namespace TP3_03;

public class Program
{
    public static void Main(string[] args)
    {
    
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