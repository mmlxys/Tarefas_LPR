#include <iostream>
using namespace std;

int main() {
     int vetor = 10; 
    int numeros[vetor]; 
    int pares[vetor], impares[vetor]; 
    int numPares = 0, numImpares = 0; 


   
    cout << "Digite 10 números inteiros:" << endl;
    for (int i = 0; i < vetor; ++i) {
        cin >> numeros[i];
    }

   
    for (int i = 0; i < vetor; ++i) {
        if (numeros[i] % 2 == 0) {
            pares[numPares] = numeros[i];
            numPares++;
        } else {
            impares[numImpares] = numeros[i];
            numImpares++;
        }
    }


    cout << "Números pares digitados:" << std::endl;
    for (int i = 0; i < numPares; ++i) {
        cout << pares[i] ;
    }
    cout <<endl;


    cout << "Números ímpares digitados:" << endl;
    for (int i = 0; i < numImpares; ++i) {
        cout << impares[i];
    }
   

    
}
