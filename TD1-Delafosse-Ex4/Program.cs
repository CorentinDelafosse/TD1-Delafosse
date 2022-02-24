// Exercice 4 :


// Préliminaire
// 1) Le nombre d’itérations est-il connu ?            ====>   NON
// 2) Est-il possible qu’il n’y ait aucune itération ? ====>   NON (car il y a 87646 habitants alors qu'on en veut 100000)
// 3) En déduire la structure itérative à utiliser :   ====>   WHILE

double habitant = 87646;
int annee = 2022;
int nombreAnnee = 0;
Console.WriteLine($"Il y a actuellement 87646 habitants à Poitier");
do
{
    annee++;
    habitant = habitant + habitant * 0.89 / 100;
    habitant = (int)habitant;
    Console.WriteLine($"Annee {annee}, Population prevue : {habitant}");

}
while (habitant < 100000);
nombreAnnee = annee - 2022;
Console.WriteLine($"il faudra {nombreAnnee} pour que Poitier atteigne les 100000 habitants");
