

using System.Runtime.InteropServices;

public class RSA
{
    public static List<string>  Chiffrement(string text,string clePublique)
    {
        List<string> texte_chiffre = new List<string>{};
        List<string> texte = new List<string>{};
        foreach (int x in text)
            Console.WriteLine(x);
        return texte_chiffre;
    }

    public static List<string>  Dechiffrement(string text,string clePrive)
    {   
        ;
        List<string> T = new List<string> { "0" };
        return T;
    }

}