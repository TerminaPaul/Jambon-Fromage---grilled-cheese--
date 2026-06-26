using System.Diagnostics;

public class Program
{
static void Main()
    {
    #if DEBUG
        Console.WriteLine($"\n==================\nDEBUG est défini !\n==================\n");
        Debug.Assert(Binaire.BinaireToCaractere("01101110") == "n");
        Debug.Assert(Binaire.BinaireToCaractere("00110000") == "0");
        Debug.Assert(Binaire.BinaireToCaractere("00110111") == "7");
        Debug.Assert(Binaire.BinaireToCaractere("00110111") != "67");
        Console.WriteLine("Tests BinaireToCaractere terminés !");
        Debug.Assert(Binaire.CaractereToBinaire("n") == "01101110");
        Debug.Assert(Binaire.CaractereToBinaire("0") == "00110000");
        Debug.Assert(Binaire.CaractereToBinaire("7") == "00110111");
        Debug.Assert(Binaire.CaractereToBinaire("5") != "10111");
        Console.WriteLine("Tests CaractereToBinaire terminés !");
        Debug.Assert(RSA.Chiffrement("CHAT", "33,3").SequenceEqual(new[] { "27", "17", "1", "14" }));
        Debug.Assert(RSA.Dechiffrement("27,17,1,14", "33,7").SequenceEqual(new[] { "C", "H", "A", "T" }));

        Console.WriteLine("Tous les tests de Binaire.cs sont terminés !");
    #else
        Console.WriteLine($"\n==================\nDEBUG n'est PAS défini\n==================\n");
    #endif
    }
}