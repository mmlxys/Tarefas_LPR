#include <iostream>

using namespace std;

int numeroReverso(int num) {
    int numeroReverso = 0;
    
    while (num != 0) {
       numeroReverso = numeroReverso * 10 + num % 10;
        num /= 10;
    }
    
    return numeroReverso;
}

int main (){
    
    int numeroInt;
    cout << "Digite um número inteiro: ";
    cin >> numeroInt;
    
    int reversao = numeroReverso(numeroInt);
    cout << "O número reverso é: " << reversao;
    return 0;
      
}
