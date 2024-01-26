namespace exerciciosTutorialCSharp;

public class Product
{
    public String Name { get; }
    public double Price { get; }


    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
    
    public static void GetProductInformation()
    {
        // Dada uma lista de produtos com nome e preço, criar uma consulta LINQ para calcular o preço médio dos produtos.
        List<Product> produtos = new List<Product>()
        {
            new Product("Coca-Cola", 5.50),
            new Product("Iphone", 5000.00),
            new Product("Batata Lays", 3.45),
            new Product("Playstation", 3280.99),
            new Product("Livro", 14.99),
            new Product("Carro", 82000.00),
            new Product("Jogo de vídeo game", 23.99),
            new Product("Celular", 999.99),
            new Product("Notebook", 4678.00),
            new Product("Flores", 45.50),
        };

        var average = produtos.Select(p=> p.Price).ToList().Average();
        Console.WriteLine("A média de preço dos produtos é: ");
        Console.Write(Math.Round(average, 2));
    }
}