public class Aluno
{
    public string Nome { get; private set; }
    public int Matricula { get; private set; }


    public Aluno(string nome, int matricula)
    {
        Nome = nome;
        Matricula = matricula;
    }

    public static void CriarAluno()
    {
        // Criar uma classe simples com um método e chame esse método em um objeto nulo. Tratar a exceção de método em objeto nulo.
        Aluno aluno = null;
        try
        {
            aluno.imprimirInformacao(aluno);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    public void imprimirInformacao(Aluno aluno)
    {
        Console.WriteLine($"Aluno: {Nome}\nMatrícula: {Matricula}");
    }
}