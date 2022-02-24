// Exercice 3 :


// Préliminaire
// 1) Le nombre d’itérations est-il connu ?          ====>   OUI (il y en a 6 (de 1 à 6))
// 2) En déduire la structure itérative à utiliser : ====>   FOR 

float prixBaguette = 0.8F;
Console.WriteLine($"Le prix d'une baguette de pain coute {prixBaguette.ToString("n2")} euros");
for (int i = 1; i <= 6; i++)
    Console.WriteLine($"{i} baguette(s) coute(nt) {(prixBaguette * i).ToString("n2")} euros");
