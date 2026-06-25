using System.Diagnostics;

public class Binaire
{

    public static string BinaireToCaractere(string binaire)
    {   
        if (binaire == null)
                {
                    Logger.PrintLog(1);
                    return string.Empty;
                }
        if (binaire.Length < 8)
                {
                    Logger.PrintLog(2);
                    return string.Empty;
                }
        if (binaire.Length > 8)
                {
                    Logger.PrintLog(3);
                    return string.Empty;
                }
        foreach (char i in binaire)
        {
            if (i != '0' && i != '1')
                {
                    Logger.PrintLog(4);
                    return string.Empty;
                }
        }
        return ((char)Convert.ToInt32(binaire, 2)).ToString();
    }

    public static string CaractereToBinaire(string caractere)
    {
        if (caractere == null)
        {
            Logger.PrintLog(1);
            return string.Empty;
        }
        if (caractere.Length != 1)
        {
            Logger.PrintLog(5);
            return string.Empty;
        }
        return Convert.ToString(caractere[0], 2).PadLeft(8, '0');
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
    } */
}}