#include <iostream>
#include <chrono>
#include <iomanip>
using namespace std;


void swap(int* valSwitch1, int* valSwitch2){
    int temp;
    temp = *valSwitch1;
    *valSwitch1 = *valSwitch2;
    *valSwitch2 = temp;
}

void triBulle(int tailleTab, int Tableau[]){
    int temp = Tableau[0];
    for (int indice = 0; indice < tailleTab; indice++){
        for (int parcour = 0; parcour < tailleTab - 1; parcour++){
            if (Tableau[parcour] > Tableau[parcour + 1]){
                swap(&Tableau[parcour], &Tableau[parcour + 1]);
            }
        }
    }
}

void triBulleAmeliore(int tailleTab, int Tableau[]){
    int temp = Tableau[0];
    bool flag = true;
        for (int indice = 0; flag != false; indice++){
            flag = false;
            for (int ind = 0; ind < tailleTab - 1; ind++){
                if (Tableau[ind] > Tableau[ind + 1]){
                    swap(&Tableau[ind], &Tableau[ind + 1]);
                    flag = true;
                }
            }
        }
}
int partionage(int low, int tailleTab, int Tableau[]){
    int pivot = Tableau[tailleTab];
    int indice1 = (low - 1);
    for (int indice2 = low; indice2 < tailleTab; indice2++){
        if (Tableau[indice2] <= pivot){
            indice1++;
            swap(&Tableau[indice1], &Tableau[indice2]);
        }
    }
    swap(&Tableau[indice1 + 1], &Tableau[tailleTab]);
    return(indice1 + 1);
}


void triRapide(int low, int tailleTab, int Tableau[]){
    if (low < tailleTab) {
        int pivot = partionage(low, tailleTab, Tableau);
        triRapide(low, pivot - 1, Tableau);
        triRapide(pivot + 1, tailleTab, Tableau);
    }
}

void Execution(int tailleTab, int choix, int Tableau[]){
    switch (choix){
    case 1: triBulle(tailleTab, Tableau); break;
    case 2: triBulleAmeliore(tailleTab, Tableau); break;
    case 3: triRapide(0, tailleTab - 1, Tableau); break;
    default: cout << "invalid"; break;
    }
}

void remplissageDecroissant(int tailleTab, int Tableau[]) {
    for (int indice = 0; indice < tailleTab; indice++) {
        Tableau[indice] = tailleTab - indice;
    }
}

int* initTableau(int tailleTab) {
    int* Tableau;
    Tableau = new int[tailleTab];
    remplissageDecroissant(tailleTab, Tableau);
    return Tableau;
}

int ChoixMethodeDeTri(){
    int choix;
    do{
        cout << "Methodes de tri (entrez 1, 2 ou 3) : " << endl;
        cout << "[1] Tri a bulle " << endl;
        cout << "[2] Tri a bulle ameliore " << endl;
        cout << "[3] Tri rapide " << endl;
        cin >> choix;
    } while (choix != 1 && choix != 2 && choix != 3);
    return choix;
}

void afficheTableau(int TailleTab, int Tableau[]){
    for (int indice = 0; indice < TailleTab; indice++){
        cout << Tableau[indice] << ", ";
    }
}

int getTailleTab(){
    int tailleTab;
    cout << "Taille : ";
    cin >> tailleTab;
    return tailleTab;
}

int main() {
    int tailleTab = getTailleTab();
    int* Tableau = initTableau(tailleTab);
    int methodeDeTri = ChoixMethodeDeTri();
    auto start = chrono::steady_clock::now();
    Execution(tailleTab, methodeDeTri, Tableau);    
    auto end = chrono::steady_clock::now();
    afficheTableau(tailleTab, Tableau);
    double tempEcoule = double(chrono::duration_cast<chrono::nanoseconds>(end - start).count());
    cout << "\nTemps d'execution : " << fixed <<tempEcoule / 1e9 <<setprecision(10) << " s";
}