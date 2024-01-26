namespace exerciciosTutorialCSharp;

public class Numeros
{
    public static void Divisao()
    {
        // Escrever um programa que solicite dois números a e b lidos do teclado e realize a divisão de a por b.
        //Caso essa operação não seja possível, mostrar uma mensagem no console que deixe claro o erro ocorrido.
        Console.Clear();
        Console.WriteLine("Divisao de b por a");
        Console.Write("Digite um número: ");
        int n1 = int.Parse(Console.ReadLine()!);
        Console.Write("Digite outro número: ");
        int n2 = int.Parse(Console.ReadLine()!);
        try
        {
            Console.WriteLine($"Resultado: {n2 / n1}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static void GetDistintNumbers()
    {
        // Dada uma lista de números, criar uma consulta LINQ para retornar apenas os elementos únicos da lista.
        List<int> lista = new List<int>() { 1, 2,2, 3, 4, 5, 5, 6, 6, 7, 8};

        var listaComNumerosDistintos = lista.Distinct().ToList();
        foreach (var numero in listaComNumerosDistintos)
        {
            Console.WriteLine(numero);
        }
    }
    public static void GetNumerosPares()
    {
        // 4.Dada uma lista de inteiros, criar uma consulta LINQ para retornar apenas os números pares.
        List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 14};

        var numerosPares = numeros.Where(n => n % 2 == 0).ToList();


        Console.WriteLine("Números pares:");

        foreach (var n in numerosPares)
        {
            Console.WriteLine(n);
        }
    }
}