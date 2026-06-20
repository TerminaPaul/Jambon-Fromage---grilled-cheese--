using System.Diagnostics;

public class Logger
{   
    [Conditional("DEBUG")]
    public static void PrintLog(int nbErreur = 0)
    {

        string message = nbErreur switch
        {
            1 => "la chaine de caractere est null",
            2 => "la chaine de caractere (binaire) a moins de 8 bits",
            3 => "la chaine de caractere (binaire) a plus de 8 bits",
            4 => "la chaine de caractere n'est pas binaire",
            5 => "la chaine de caractere (Caractere) a plus que 1 caractere",
            _ => "inconnue"
        };
        Console.WriteLine($"Erreur {nbErreur} : {message}");
    }
}