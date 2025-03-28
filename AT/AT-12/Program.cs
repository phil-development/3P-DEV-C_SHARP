namespace AT_12
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class GerenciadorContatos
    {
        static string nomeArquivo = "contatos.txt";

        static void Main(string[] args)
        {
            List<Contato> contatos = CarregarContatos();

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
                            AdicionarContato(contatos);
                            break;
                        case 2:
                            ExibirContatosFormatados(contatos);
                            break;
                        case 3:
                            SalvarContatos(contatos);
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

        static List<Contato> CarregarContatos()
        {
            List<Contato> contatos = new List<Contato>();
            try
            {
                if (File.Exists(nomeArquivo))
                {
                    string[] linhas = File.ReadAllLines(nomeArquivo);

                    foreach (string linha in linhas)
                    {
                        string[] dados = linha.Split(',');
                        if (dados.Length == 3)
                        {
                            contatos.Add(new Contato(dados[0], dados[1], dados[2]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar contatos: {ex.Message}");
            }
            return contatos;
        }

        static void SalvarContatos(List<Contato> contatos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(nomeArquivo))
                {
                    foreach (Contato contato in contatos)
                    {
                        sw.WriteLine(contato.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar contatos: {ex.Message}");
            }
        }

        static void AdicionarContato(List<Contato> contatos)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            contatos.Add(new Contato(nome, telefone, email));
            Console.WriteLine("Contato cadastrado com sucesso!");
        }

        static void ExibirContatosFormatados(List<Contato> contatos)
        {
            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                return;
            }

            Console.WriteLine("Escolha o formato de exibição:");
            Console.WriteLine("1 - Markdown");
            Console.WriteLine("2 - Tabela");
            Console.WriteLine("3 - Texto Puro");
            Console.Write("Formato: ");

            if (int.TryParse(Console.ReadLine(), out int formato))
            {
                ContatoFormatter formatter = null;
                switch (formato)
                {
                    case 1:
                        formatter = new MarkdownFormatter();
                        break;
                    case 2:
                        formatter = new TabelaFormatter();
                        break;
                    case 3:
                        formatter = new RawTextFormatter();
                        break;
                    default:
                        Console.WriteLine("Formato inválido.");
                        return;
                }
                formatter.ExibirContatos(contatos);
            }
            else
            {
                Console.WriteLine("Formato inválido.");
            }
        }
    }
}