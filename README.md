cod1
#include <iostream>

using namespace std;

int main() {
    
    int numero;
    
    cout << "Digite um número inteiro: ";
    cin >> numero;
    
    if (numero % 2 == 0) {
        
        cout << "Par";
        
    }
    else {
        cout << "Impar";
    }
    
    return 0;
}

cod2
#include <iostream>

using namespace std;

int main() {
    
    int A, B;
    
    cout << "Digite o valor de A: ";
    cin >> A;
    
    cout << "Digite o valor de B: ";
    cin>> B;
    
    
    if ( A % B == 0 ) {
        
        cout << "Multiplos";
        
    }
    else {
        cout << "Nao sao multiplos";
    }
    
    return 0;
}

cod3
using System;
class exercicio3 {
    static void Main() {
        
        int escolha;
        
        Console.WriteLine("Menu: Escolha sua classe");
        Console.WriteLine("1 - Guerreira");
        Console.WriteLine("2 - Mago");
        Console.WriteLine("3 - Arqueira");
        
        Console.Write("Escolha sua classe (digite o número correspondente): ");
        escolha = int.Parse(Console.ReadLine());
        
        if (escolha == 1) {
            Console.WriteLine("Habilidades da Guerreira: Ataque Pesado, Defesa Total"); 
        }
        else if (escolha == 2) {
            Console.WriteLine("Habilidades do Mago:Bola de Fogo, Escudo de Gelo");
        } else if (escolha == 3) {
            Console.WriteLine("Habilidades da Arqueira: Flecha Precisa, Disparo Triplo");
        }
    }
}
