// Exercice 1 :


//1)  d = 65.21       // i ne peut pas s'initialiser (faut int i = (int)d )
//    pof = 148       // puf = 148
//    d1 = 3.214      // i1 = 3
//    paf = 34        // pif = 34
//    age = 20        // statut = "majeur"
//    raoul = "651"   // regis = 651


//2)  il affiche :
//    12
//    14
//    16
//    18

//3)  il n'affiche rien car pif = 20 et que la boucle ne commence que si pif est < à 20



// Exercice 2 :


Console.WriteLine("Entrez votre age");
string str = Console.ReadLine();
int age = Convert.ToInt32(str);
while (age < 0 || age > 120)
{
    Console.WriteLine("Age incorrect ! Veuillez reentrer votre age");
    str = Console.ReadLine();
    age = Convert.ToInt32(str);
}
string statut = (age < 18) ? "mineur" : "majeur";
Console.WriteLine($"Vous etes {statut}");