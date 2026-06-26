using System.Diagnostics;

public class Program
{
static void Main()
    {
    #if DEBUG
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n==================\nDEBUG est défini !\n==================\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Debuts des tests de Binaire.cs!");

        Console.ForegroundColor = ConsoleColor.Green;

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

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"\nTous les tests de Binaire.cs sont terminés !\n");

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine($"Debuts des tests de RSA.cs");

        Console.ForegroundColor = ConsoleColor.Green;

        Debug.Assert(RSA.Chiffrement("CHAT", "17,3233").SequenceEqual(new[] { "641", "3000", "2790", "2159" }));
        Console.WriteLine($"    Tests Chiffrement terminés !");

        Debug.Assert(RSA.Dechiffrement(new List<string> { "641", "3000", "2790", "2159" }, "2753,3233") == "CHAT");
        Console.WriteLine($"    Tests Dechiffrement terminés !");

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.WriteLine($"\nTous les tests de RSA.cs sont terminés !\n");
        Console.ResetColor();
    #else
        Console.WriteLine($"\n==================\nDEBUG n'est PAS défini\n==================\n");
    #endif
    }
}