using System.Numerics;

public class RSA
{
    public static string[] SeparationCle(string cle)
    {
        string[] cle_ = cle.Split(",");   
        if (int.Parse(cle_[1]) <= 127)
        {
            Logger.PrintLog(6);
            throw new ArgumentException("Clé invalide");
        }
        return cle_;

    } 

    public static List<string> Chiffrement(string text, string clePublique)
    {
        List<string> texte_chiffre = new List<string>{};
        string[] clepublique = SeparationCle(clePublique);
        
        foreach (int x in text)
        {
            texte_chiffre.Add(BigInteger.ModPow(x, BigInteger.Parse(clepublique[0].ToString()), BigInteger.Parse(clepublique[1].ToString())).ToString());
        }
        return texte_chiffre;
    }

    public static string  Dechiffrement(List<string> text,string clePrive)
    {
        string texte_dechiffre = string.Empty;
        string[] cleprive = SeparationCle(clePrive);

        foreach (string x in text)
        {
            texte_dechiffre += (char)BigInteger.ModPow(BigInteger.Parse(x), BigInteger.Parse(cleprive[0].ToString()), BigInteger.Parse(cleprive[1].ToString()));
        }
        return texte_dechiffre;
    }

}