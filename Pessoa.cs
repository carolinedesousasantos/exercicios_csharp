using System.Text.Json;

namespace exerciciosTutorialCSharp;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }

    public Pessoa(string nome, int idade, string email)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
    }
    
    public string GerarArquivoJsonParaUmaPessoa(Pessoa pessoa)
    {
        string json = JsonSerializer.Serialize(pessoa);
        string nomeDoArquivo = $"informacao-{pessoa.Nome}.json";
        
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
        return nomeDoArquivo;
    }
    
    public static string SerializeInformacoesPessoa()
    {
        string nomeDoArquivo = "";
        // Criar um programa que permite ao usuário inserir informações de uma pessoa (nome, idade, e e-mail), serializa essas informações em formato JSON e salva em um arquivo.
        Console.WriteLine("Guardar informaçoes cliente:");
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o email: ");
        string email = Console.ReadLine()!;

        Pessoa pessoa = new Pessoa(nome, idade, email);
        Console.WriteLine("Digite enter para salvar as informaçoes do cliente em formato json.");

        var keyInfo = Console.ReadKey();
        if (keyInfo.Key== ConsoleKey.Enter)
        {
            nomeDoArquivo = pessoa.GerarArquivoJsonParaUmaPessoa(pessoa);
        }
        else
        {
            Console.WriteLine("Digite enter para salvar as informaçoes do cliente em formato json");
        }

        return nomeDoArquivo;
    }

    public static void DeserializeInformacaoPessoa()
    {
        // Criar um programa que lê um arquivo JSON contendo informações de uma pessoa, desserializa essas informações e exibe na tela.   
        string nomeDoArquivo = SerializeInformacoesPessoa();
        if (File.Exists(nomeDoArquivo))
        {
            string jsonString = File.ReadAllText(nomeDoArquivo);
            
            Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(jsonString);

            Console.WriteLine("Exibindo dados do arquivo:");
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine($"E-mail: {pessoa.Email}");
        }
        else
        {
            Console.WriteLine($"O arquivo {nomeDoArquivo} não existe.");
        }
    }
    public static string SerealizarListaPessoas()
    {
        // Criar um lista de pessoas, serializa a lista em formato JSON e salva em um arquivo.
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa("Caroline", 35, "carol@carol"),
            new Pessoa("Humberto", 40, "beto@beto.com"),
            new Pessoa("Wilson", 1, "will@will"),
            new Pessoa("Frida", 1, "frida@kalopsita")
        };
        string nomeDoArquivo = "pessoas.json";
        string jsonString = JsonSerializer.Serialize(pessoas);

        try
        {
            File.WriteAllText(nomeDoArquivo,jsonString);
            Console.WriteLine($"Arquivo gerado com sucesso! Path: {Path.GetFullPath(nomeDoArquivo)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return nomeDoArquivo;
    }

   public static void  DeserializarListaPessoas()
    {
        // Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, desserializa essas informações em uma lista e exibe na tela.
        string nomeDoArquivo =  SerealizarListaPessoas();
        if (File.Exists(nomeDoArquivo))
        {
          string jsonString = File.ReadAllText(nomeDoArquivo);
          List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);
          
          Console.WriteLine("Exibindo dados do arquivo:");

          foreach (var pessoa in pessoas)
          {
              Console.WriteLine($"Nome: {pessoa.Nome}--Idade: {pessoa.Idade}--Email: {pessoa.Email}");
          }
        }
        
    }

    public static void FiltrarPessoasPorIdade()
    {
        // Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, permite ao usuário inserir uma idade e exibe as pessoas com aquela idade.

        Console.WriteLine("Digite o nome do arquivo");
        string nomeDoArquivo = Console.ReadLine()!;
        Console.WriteLine("Digite a idade que deseja filtrar");
        int idade = int.Parse(Console.ReadLine()!);
        if (File.Exists(nomeDoArquivo))
        {
            string jsonString = File.ReadAllText(nomeDoArquivo);
            List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);

        var consulta = pessoas
            .Where(p => p.Idade! == idade)
            .Distinct()    
            .ToList();
        
        foreach (var item in consulta)
        {
            Console.WriteLine(item.Nome);
        }
        
        }
    }
}