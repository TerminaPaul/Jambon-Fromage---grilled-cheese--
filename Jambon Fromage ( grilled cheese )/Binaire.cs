using System.Diagnostics;

public class Binaire
{

    public static string BinaireToCaractere(string binaire)
    {   
        if (binaire == null)
                {
                    PrintLog(1);
                    return string.Empty;
                }
        else if (binaire.Length < 8)
                {
                    PrintLog(2);
                    return string.Empty;
                }
        else if (binaire.Length > 8)
                {
                    PrintLog(3);
                    return string.Empty;
                }
        foreach (char i in binaire)
        {
            if (i != '0' && i != '1')
                {
                    PrintLog(4);
                    return string.Empty;
                }
        }
        return ((char)Convert.ToInt32(binaire, 2)).ToString();
    }

    public static string CaractereToBinaire(string caractere)
    {
        if (caractere == null)
        {
            PrintLog(1);
            return string.Empty;
        }
        if (caractere.Length != 1)
        {
            PrintLog(5);
            return string.Empty;
        }
        return Convert.ToString(caractere[0], 2).PadLeft(8, '0');
    }


    [Conditional("DEBUG")]
    static void PrintLog(int nbErreur = 0)
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

    static void Main()
    {
    #if DEBUG
        Console.WriteLine($"\n==================\nDEBUG est défini !\n==================\n");
    #else
        Console.WriteLine($"\n==================\nDEBUG n'est PAS défini\n==================\n");
    #endif
        Debug.Assert(BinaireToCaractere("01101110") == "n");
        Debug.Assert(BinaireToCaractere("00110000") == "0");
        Debug.Assert(BinaireToCaractere("00110111") == "7");
        Debug.Assert(BinaireToCaractere("00110111") != "67");
        Console.WriteLine("Tests BinaireToCaractere terminés !");
        Debug.Assert(CaractereToBinaire("n") == "01101110");
        Debug.Assert(CaractereToBinaire("0") == "00110000");
        Debug.Assert(CaractereToBinaire("7") == "00110111");
        Debug.Assert(CaractereToBinaire("5") != "10111");
        Console.WriteLine("Tests CaractereToBinaire terminés !");
        Console.WriteLine("Tous les tests sont terminés !");
    }
}