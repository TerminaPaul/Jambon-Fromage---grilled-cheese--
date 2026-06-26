using System.Diagnostics;

public class Program
{
static void Main()
    {
    #if DEBUG
        Console.WriteLine($"\n==================\nDEBUG est défini !\n==================\n");
        Console.WriteLine($"Debuts des tests de Binaire.cs!\n");
        Debug.Assert(Binaire.BinaireToCaractere("01101110") == "n");
        Debug.Assert(Binaire.BinaireToCaractere("00110000") == "0");
        Debug.Assert(Binaire.BinaireToCaractere("00110111") == "7");
        Debug.Assert(Binaire.BinaireToCaractere("00110111") != "67");
        Console.WriteLine($"    Tests BinaireToCaractere terminés !");
        Debug.Assert(Binaire.CaractereToBinaire("n") == "01101110");
        Debug.Assert(Binaire.CaractereToBinaire("0") == "00110000");
        Debug.Assert(Binaire.CaractereToBinaire("7") == "00110111");
        Debug.Assert(Binaire.CaractereToBinaire("5") != "10111");
        Console.WriteLine($"    Tests CaractereToBinaire terminés !");
        Console.WriteLine($"\nTous les tests de Binaire.cs sont terminés !\n");
        Debug.Assert(RSA.Chiffrement("CHAT", "17,3233").SequenceEqual(new[] { "641", "3000", "2790", "2159" }));
        //Debug.Assert(RSA.Dechiffrement("27,17,1,14", "17,3233").SequenceEqual(new[] { "C", "H", "A", "T" }));
    #else
        Console.WriteLine($"\n==================\nDEBUG n'est PAS défini\n==================\n");
    #endif
    }
}