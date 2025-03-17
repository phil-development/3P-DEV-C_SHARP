namespace TP3_01;

public class Program
{
    public static void Main(string[] args)
    {
        Livro meuLivro = new Livro();

        meuLivro.Titulo = "O Senhor dos Anéis";
        meuLivro.Autor = "J.R.R. Tolkien";

        meuLivro.ExibirInformacoes();
    }
}

public class Livro
{
    public string Titulo;
    public string Autor;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
    }
}