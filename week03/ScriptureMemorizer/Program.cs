using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        ScriptureReference reference = new ScriptureReference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the LORD with all your heart and lean not on your own understanding");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit") break;

            scripture.HideRandomWords(2);

            if (scripture.AllWordsHidden()) break;
        }

        Console.Clear();
        Console.WriteLine(scripture);
        Console.WriteLine("\nAll words are hidden. Program ended.");
    }
}
