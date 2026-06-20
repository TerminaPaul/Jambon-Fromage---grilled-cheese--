using System.Diagnostics;

public class Binaire
{
    [Conditional("DEBUG")]
    static void PrintLog(int nbErreur = 0)
    {
        if (nbErreur == 0){Console.WriteLine("Aucune erreur");}

        else if (nbErreur == 1){
            Console.WriteLine("Erreur 1 : ");
            }
        else {
            Console.WriteLine($"Erreur {nbErreur} : inconnue");
            }
    }

    static void Test()
    {
        PrintLog(1);
    }

    static void Main()
    {
    #if DEBUG
        Console.WriteLine("DEBUG est défini !");
    #else
        Console.WriteLine("DEBUG n'est PAS défini");
    #endif
        Test();
    }
}