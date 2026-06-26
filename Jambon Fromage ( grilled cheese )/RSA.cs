using System.Numerics;

public class RSA
{
    public static List<string> Chiffrement(string text, string clePublique)
    {
        List<string> texte_chiffre = new List<string>{};
        string[] clepublique = clePublique.Split(",");        
        foreach (int x in text)
        {
            Console.WriteLine($"{x}");
            texte_chiffre.Add(BigInteger.ModPow(x, BigInteger.Parse(clepublique[0].ToString()), BigInteger.Parse(clepublique[1].ToString())).ToString());
        }
        return texte_chiffre;
    }

    public static List<string>  Dechiffrement(string text,string clePrive)
    {   
        ;
        List<string> T = new List<string> { "0" };
        return T;
    }

}