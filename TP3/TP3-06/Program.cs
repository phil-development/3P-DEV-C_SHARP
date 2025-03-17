namespace TP3_06;

public class Program
{
    public static void Main(string[] args)
    {

        Ingresso ingresso = new Ingresso("Show da Banda Z", 120.0, 150);

        Console.WriteLine($"Nome do Show: {ingresso.GetNomeDoShow()}");
        Console.WriteLine($"Preço: R${ingresso.GetPreco()}");
        Console.WriteLine($"Quantidade Disponível: {ingresso.GetQuantidadeDisponivel()}");
    }
}

public class Ingresso
{
    private string nomeDoShow;
    private double preco;
    private int quantidadeDisponivel;

    public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
    {
        this.nomeDoShow = nomeDoShow;
        this.preco = preco;
        this.quantidadeDisponivel = quantidadeDisponivel;
    }

    public string GetNomeDoShow()
    {
        return nomeDoShow;
    }

    public double GetPreco()
    {
        return preco;
    }

    public int GetQuantidadeDisponivel()
    {
        return quantidadeDisponivel;
    }

    public void SetNomeDoShow(string novoNome)
    {
        nomeDoShow = novoNome;
    }

    public void SetPreco(double novoPreco)
    {
        preco = novoPreco;
    }

    public void SetQuantidadeDisponivel(int novaQtd)
    {
        quantidadeDisponivel = novaQtd;
    }
}