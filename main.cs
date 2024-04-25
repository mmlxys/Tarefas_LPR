using System;

class herois {
    
    static string nomeHeroi1, nomeHeroi2, nomeHeroi3, nomeHeroi4, nomeHeroi5;
    static string poderHeroi1, poderHeroi2, poderHeroi3, poderHeroi4, poderHeroi5;
    static int pontuacaoHeroi1, pontuacaoHeroi2, pontuacaoHeroi3, pontuacaoHeroi4, pontuacaoHeroi5;
    static int pontuacaoTotalEquipe = 0;

    
    static void cadastrarHeroi ()
    {
        Console.WriteLine("Digite o nome do seu herói 1:");
        nomeHeroi1 = Console.ReadLine();
        Console.WriteLine("Digite o poder do seu herói 1:");
        poderHeroi1 = Console.ReadLine();
        Console.WriteLine("Digite a pontuação do seu herói 1:");
        pontuacaoHeroi1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o nome do seu herói 2:");
        nomeHeroi2 = Console.ReadLine();
        Console.WriteLine("Digite o poder do seu herói 2:");
        poderHeroi2 = Console.ReadLine();
        Console.WriteLine("Digite a pontuação do seu herói 2:");
        pontuacaoHeroi2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o nome do seu herói 3:");
        nomeHeroi3 = Console.ReadLine();
        Console.WriteLine("Digite o poder do seu herói 3:");
        poderHeroi3 = Console.ReadLine();
        Console.WriteLine("Digite a pontuação do seu herói 3:");
        pontuacaoHeroi3 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o nome do seu herói 4:");
        nomeHeroi4 = Console.ReadLine();
        Console.WriteLine("Digite o poder do seu herói 4:");
        poderHeroi4 = Console.ReadLine();
        Console.WriteLine("Digite a pontuação do seu herói 4:");
        pontuacaoHeroi4 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o nome do seu herói 5:");
        nomeHeroi5 = Console.ReadLine();
        Console.WriteLine("Digite o poder do seu herói 5:");
        poderHeroi5 = Console.ReadLine();
        Console.WriteLine("Digite a pontuação do seu herói 5:");
        pontuacaoHeroi5 = int.Parse(Console.ReadLine());
    }

    static void selecionarEquipe ()
    {
        Console.WriteLine("Agora selecione sua equipe! Você pode escolher até 3 heróis:");
        Console.WriteLine($"1. {nomeHeroi1} - {poderHeroi1} - Pontuação: {pontuacaoHeroi1}");
        Console.WriteLine($"2. {nomeHeroi2} - {poderHeroi2} - Pontuação: {pontuacaoHeroi2}");
        Console.WriteLine($"3. {nomeHeroi3} - {poderHeroi3} - Pontuação: {pontuacaoHeroi3}");
        Console.WriteLine($"4. {nomeHeroi4} - {poderHeroi4} - Pontuação: {pontuacaoHeroi4}");
        Console.WriteLine($"5. {nomeHeroi5} - {poderHeroi5} - Pontuação: {pontuacaoHeroi5}");
         
        Console.Write("Herói 1: ");
        nomeHeroi1 = Console.ReadLine();
        pontuacaoTotalEquipe += calcularPontuacaoTotal(nomeHeroi1);

        Console.Write("Herói 2: ");
        nomeHeroi2 = Console.ReadLine();
        pontuacaoTotalEquipe += calcularPontuacaoTotal(nomeHeroi2);

        Console.Write("Herói 3: ");
        nomeHeroi3 = Console.ReadLine();
        pontuacaoTotalEquipe += calcularPontuacaoTotal(nomeHeroi3);

        Console.WriteLine("Boas escolhas! Equipe definida com sucesso");
    }
    
    static int calcularPontuacaoTotal(string nome)
    {
        if (nome == nomeHeroi1)
        {
            return pontuacaoHeroi1;
        }
        else if (nome == nomeHeroi2)
        {
            return pontuacaoHeroi2;
        }
        else if (nome == nomeHeroi3)
        {
            return pontuacaoHeroi3;
        }
        else if (nome == nomeHeroi4)
        {
            return pontuacaoHeroi4;
        }
        else if (nome == nomeHeroi5)
        {
            return pontuacaoHeroi5;
        }
        else
        {
            return 0;
        }
    }
    
    static void ExibirEquipe()
    {
        Console.WriteLine("Equipes: ");
        Console.WriteLine("Seu clã: ");
        Console.WriteLine($"{nomeHeroi1} - Pontuação: {pontuacaoHeroi1}");
        Console.WriteLine($"{nomeHeroi2} - Pontuação: {pontuacaoHeroi2}");
        Console.WriteLine($"{nomeHeroi3} - Pontuação: {pontuacaoHeroi3}");
        Console.WriteLine($"Pontuação total da equipe: {pontuacaoTotalEquipe}");
    }

    static void Main ()
    {
        int selecaoMenu;
        Console.WriteLine("--Menu--");
        Console.WriteLine("1.Cadastro de heróis");
        Console.WriteLine("2.Seleção de equipe");
        Console.WriteLine("3.Exibição da equipe");
        Console.WriteLine("4.Sair");
 
        selecaoMenu = int.Parse(Console.ReadLine());
 
        switch (selecaoMenu)
        {
            case 1:
                cadastrarHeroi();
                break;
            case 2:
                selecionarEquipe();
                break;
            case 3:
                ExibirEquipe();
                break;
            default:
                Console.WriteLine("Saindo...");
                break;
        }
    }
}
