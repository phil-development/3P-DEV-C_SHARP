namespace TP3_05;

public class Program
{ 
    public static void Main(string[] args)
    {
        Ingresso ingresso = new Ingresso();

        ingresso.SetNomeDoShow("Show da Banda");
        ingresso.SetPreco(150.0);
        ingresso.SetQuantidadeDisponivel(200);

        Console.WriteLine($"Nome do Show: {ingresso.GetNomeDoShow()}");
        Console.WriteLine($"Preço: R${ingresso.GetPreco()}");
        Console.WriteLine($"Quantidade Disponível: {ingresso.GetQuantidadeDisponivel()}");

        ingresso.SetPreco(200.0);
        Console.WriteLine($"Novo Preço: R${ingresso.GetPreco()}");
    }
}

public class Ingresso
{
    private string nomeDoShow;
    private double preco;
    private int quantidadeDisponivel;

    // Métodos Get (Leitura)
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
