using System;
using System.IO;

public class GerenciadorEstoque
{
    static string[] nomesProdutos = new string[5];
    static int[] quantidadesProdutos = new int[5];
    static double[] precosProdutos = new double[5];
    static int numProdutos = 0;
    static string nomeArquivo = "estoque.txt";

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("\nMenu de Opções:");
            Console.WriteLine("1. Inserir Produto");
            Console.WriteLine("2. Listar Produtos");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                opcao = 0;
            }

            switch (opcao)
            {
                case 1:
                    InserirProdutoArquivo();
                    break;
                case 2:
                    ListarProdutosArquivo();
                    break;
                case 3:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (opcao != 3);
    }

    static void InserirProdutoArray()
    {
        if (numProdutos < 5)
        {
            Console.Write("Nome do produto: ");
            nomesProdutos[numProdutos] = Console.ReadLine();

            Console.Write("Quantidade em estoque: ");
            quantidadesProdutos[numProdutos] = int.Parse(Console.ReadLine());

            Console.Write("Preço unitário: ");
            precosProdutos[numProdutos] = double.Parse(Console.ReadLine());

            numProdutos++;
            Console.WriteLine("Produto cadastrado com sucesso!");
        }
        else
        {
            Console.WriteLine("Limite de produtos atingido!");
        }
    }

    static void ListarProdutosArray()
    {
        if (numProdutos == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
        }
        else
        {
            for (int i = 0; i < numProdutos; i++)
            {
                Console.WriteLine($"Produto: {nomesProdutos[i]} | Quantidade: {quantidadesProdutos[i]} | Preço: R$ {precosProdutos[i]:N2}");
            }
        }
    }

    static void InserirProdutoArquivo()
    {
        Console.Write("Nome do produto: ");
        string nome = Console.ReadLine();

        Console.Write("Quantidade em estoque: ");
        int quantidade = int.Parse(Console.ReadLine());

        Console.Write("Preço unitário: ");
        double preco = double.Parse(Console.ReadLine());

        try
        {
            using (StreamWriter sw = File.AppendText(nomeArquivo))
            {
                sw.WriteLine($"{nome},{quantidade},{preco:F2}");
            }
            Console.WriteLine("Produto cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao gravar no arquivo: {ex.Message}");
        }
    }

    static void ListarProdutosArquivo()
    {
        try
        {
            if (File.Exists(nomeArquivo))
            {
                string[] linhas = File.ReadAllLines(nomeArquivo);

                if (linhas.Length == 0)
                {
                    Console.WriteLine("Nenhum produto cadastrado.");
                }
                else
                {
                    foreach (string linha in linhas)
                    {
                        string[] dados = linha.Split(',');
                        Console.WriteLine($"Produto: {dados[0]} | Quantidade: {dados[1]} | Preço: R$ {double.Parse(dados[2]):N2}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
        }
    }
}