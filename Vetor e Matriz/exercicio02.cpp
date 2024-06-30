#include <iostream>
using namespace std;

int main() {
     int vetor = 10;
    int numeros[vetor];
    int numero;
    int vezes = 0;

   
    cout << "Digite 10 números inteiros:" << endl;
    for (int i = 0; i < vetor; ++i) {
        cin >> numeros[i];
    }

    cout << "Digite o número que deseja pesquisar: ";
    cin >> numero;

    cout << "Resultado:" << endl;
    for (int i = 0; i < vetor; ++i) {
        if (numeros[i] == numero) {
            cout << "O número " << numero << " foi encontrado na posição " << i << endl;
            vezes++;
        }
    }

    if (vezes > 0) {
        cout << "Total encontrado: " << vezes << endl;
    } else {
        cout << "O número " << numero << " não foi encontrado no vetor." << endl;
    }

    return 0;
}