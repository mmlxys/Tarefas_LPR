using System;

class Aluno
{
    // Atributos do aluno
    public int Matricula;
    public string Nome;
    public double Nota1; // Primeira nota da prova
    public double Nota2; // Segunda nota da prova
    public double NotaTrabalho; // Nota do trabalho

    public double Media()
    {
        return (Nota1 * 2.5 + Nota2 * 2.5 + NotaTrabalho * 2) / 7.0;
    }


    public double Final()
    {
        double mediaFinal = Media();

        
        if (mediaFinal >= 6.0)
        {
            return 0;
        }

       
        return (6.0 * 7.0) - (Nota1 * 2.5 + Nota2 * 2.5 + NotaTrabalho * 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
    
        Aluno aluno = new Aluno();

        
        Console.Write("Digite a matrícula do aluno: ");
        aluno.Matricula = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o nome do aluno: ");
        aluno.Nome = Console.ReadLine();

        Console.Write("Digite a nota da primeira prova: ");
        aluno.Nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota da segunda prova: ");
        aluno.Nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota do trabalho: ");
        aluno.NotaTrabalho = Convert.ToDouble(Console.ReadLine());

     
        Console.WriteLine($"\nMédia final de {aluno.Nome}: {aluno.Media():F2}");

        double notaFinal = aluno.Final();
        if (notaFinal == 0)
        {
            Console.WriteLine($"{aluno.Nome} não precisa fazer a prova final.");
        }
        else
        {
            Console.WriteLine($"Nota necessária para a prova final: {notaFinal:F2}");
        }
    }
}