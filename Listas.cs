namespace exerciciosTutorialCSharp;

public class Listas
{
    public static void ListaComIndiceInexistente()
    {
        // Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente. Tratar a exceção apropriada.
        List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6 };
        try
        {
            Console.WriteLine(lista[6]);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}