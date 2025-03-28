namespace AT_11;

using System;
using System.IO;

public class GerenciadorContatos
{
    static string nomeArquivo = "contatos.txt";

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("\n=== Gerenciador de Contatos ===");
            Console.WriteLine("1 - Adicionar novo contato");
            Console.WriteLine("2 - Listar contatos cadastrados");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        AdicionarContato();
                        break;
                    case 2:
                        ListarContatos();
                        break;
                    case 3:
                        Console.WriteLine("Encerrando programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        } while (opcao != 3);
    }

    static void AdicionarContato()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        try
        {
            using (StreamWriter sw = File.AppendText(nomeArquivo))
            {
                sw.WriteLine($"{nome},{telefone},{email}");
            }
            Console.WriteLine("Contato cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao cadastrar contato: {ex.Message}");
        }
    }

    static void ListarContatos()
    {
        try
        {
            if (File.Exists(nomeArquivo))
            {
                string[] linhas = File.ReadAllLines(nomeArquivo);

                if (linhas.Length == 0)
                {
                    Console.WriteLine("Nenhum contato cadastrado.");
                }
                else
                {
                    Console.WriteLine("Contatos cadastrados:");
                    foreach (string linha in linhas)
                    {
                        string[] dados = linha.Split(',');
                        Console.WriteLine($"Nome: {dados[0]} | Telefone: {dados[1]} | Email: {dados[2]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Nenhum contato cadastrado.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao listar contatos: {ex.Message}");
        }
    }
}