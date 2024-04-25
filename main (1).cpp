#include <iostream>
using namespace std;

void tarefa1() {
    int quantidade, numero, soma = 0, contador = 0;

    cout << "Digite a quantidade de números: ";
    cin >> quantidade;

    while (quantidade > 0) {
        cout << "Digite um numero: ";
        cin >> numero;

        if (numero % 2 == 0) {
            soma += numero;
            contador++;
        }

        quantidade--;
    }

    if (contador == 0) {
        cout << "Você não digitou numeros pares, tente novamente" << endl;
    } else {
        double media = soma / contador;
        cout << "A média dos numeros pares é: " << media << endl;
    }
}

void tarefa2() {
    int soma = 0;

    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }

    cout << "A soma dos números ímpares múltiplos de 3 de 50 a 500 é: " << soma << endl;
}

void tarefa4() {
    int numero;
    cout << "Digite um número:";
    cin >> numero;

    int quadrado = numero * numero;
    int somaDigitos = 0;

    while (quadrado != 0) {
        int digito = quadrado % 10;
        somaDigitos += digito;
        quadrado /= 10;
    }

    cout << "A soma dos dígitos do quadrado do número é: " << somaDigitos << endl;
}

int main() {
    int escolha;
    cout << "Escolha a tarefa que deseja visualizar:" << endl;
    cout << "Tarefa 1 - Soma" << endl;
    cout << "Tarefa 2 - Soma de números ímpares" << endl;
    cout << "Tarefa 3 - Soma dos digitos e seu quadrado" << endl;

    cin >> escolha;

    switch (escolha) {
        case 1:
            tarefa1();
            break;
        case 2:
            tarefa2();
            break;
        case 3:
            tarefa4();
            break;
        default:
            cout << "Numero invalido";
    }

    return 0;
}
