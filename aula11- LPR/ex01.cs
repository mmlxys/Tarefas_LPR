using System;

class Retangulo
{
    public double Altura { get; set; }
    public double Largura { get; set; }

    public Retangulo(double altura, double largura)
    {
        Altura = altura;
        Largura = largura;
    }

    public double CalcArea()
    {
        return Altura * Largura;
    }

    public double CalcPerimetro()
    {
        return 2 * (Altura + Largura);
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Digite a altura do retângulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a largura do retângulo: ");
        double largura = Convert.ToDouble(Console.ReadLine());

        
        Retangulo retangulo = new Retangulo(altura, largura);

       
        double area = retangulo.CalcArea();
        double perimetro = retangulo.CalcPerimetro();

        Console.WriteLine($"A área do retângulo é: {area}");
        Console.WriteLine($"O perímetro do retângulo é: {perimetro}");
    }
}
