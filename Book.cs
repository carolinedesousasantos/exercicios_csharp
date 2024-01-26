namespace exerciciosTutorialCSharp;

public class Book
{
    public string Titulo { get; }
    public string Autor { get; }
    public int AnoPublicacao { get; }

    public Book(string titulo, string autor, int anoPublicacao)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
    }
    
    public static void GetBooksList()
    {
        // Dada uma lista de livros com título, autor e ano de publicação, criar uma consulta LINQ para retornar uma lista com os títulos dos livros publicados após o ano 1950, ordenados alfabeticamente.
        List<Book> books = new List<Book>()
        {
            new("Grandes Sertoes Veredas","Joao Guimaraes Rosa", 2000),
            new("O Senhor dos Aneis","Willian Golding", 1954),
            new("A hora dos ruminantes","José Veiga", 1966),
            new("Admirável mundo novo","Aldous Huxley", 1932),
            new("1984","George Orwell", 1949),
            new("As crônicas de Nárnia","C. S. Lewis", 1950),
            new("A gerra dos tronos","George R.R.Martin", 1996),
            new("O Hobbit","J. R. R. Tolkien", 1937),
            new("As Aventuras de Sherlock Holmes","Arthur Conan Dayle", 1892),
            new("A máquina do tempo","G. G. Wells", 1895),
            new("O poderoso chefao","Mario Puzo", 1969)
        };

        var resultado = books
            .OrderBy(livro => livro.Titulo)
            .Where(livro => livro.AnoPublicacao >= 1950)
            .Select(livro => livro.Titulo);
        Console.WriteLine("Livros publicados a partir de 1950:");
        foreach (var livro in resultado)
        {
            Console.WriteLine($"{livro}");
        }
    }
}