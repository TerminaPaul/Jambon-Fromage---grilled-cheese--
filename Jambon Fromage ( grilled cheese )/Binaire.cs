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
}