using System;

class Funcionario
{
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public Funcionario(string nome, double salarioBruto)
    {
        Nome = nome;
        SalarioBruto = salarioBruto;
        Imposto = CalcularImposto(salarioBruto);
    }

    private double CalcularImposto(double salario)
    {
        if (salario <= 2000)
            return salario * 0.10; // 10% de imposto
        else if (salario <= 3000)
            return salario * 0.15; // 15% de imposto
        else
            return salario * 0.20; // 20% de imposto
    }

    public double SalarioLiquido()
    {
        return SalarioBruto - Imposto;
    }

    public void AumentarSalario(double percentual)
    {
        SalarioBruto += SalarioBruto * (percentual / 100);
        Imposto = CalcularImposto(SalarioBruto); // Atualiza o imposto
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Salário Líquido: {SalarioLiquido():F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Digite o nome do funcionário: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o salário bruto do funcionário: ");
        double salarioBruto = Convert.ToDouble(Console.ReadLine());

        Funcionario funcionario = new Funcionario(nome, salarioBruto);


        funcionario.MostrarDados();

        Console.Write("Digite a porcentagem de aumento: ");
        double percentualAumento = Convert.ToDouble(Console.ReadLine());


        funcionario.AumentarSalario(percentualAumento);

        Console.WriteLine("\nDados atualizados:");
        funcionario.MostrarDados();
    }
}