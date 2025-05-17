/*
Improvements to exceed requirements:
1) Save data in Excel-compatible .csv format.
2) Use JSON to save and load records.
3) Add an automatic daily reminder to encourage writing.
4) Allow the user to choose categories for their entries.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2: Display the journal");
            Console.WriteLine("3: Save the journal to a file");
            Console.WriteLine("4: Load the journal from a file");
            Console.WriteLine("5: Exit");

            Console.WriteLine("Choose an option");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.WriteLine("Your response: ");
                    string response = Console.ReadLine();
                    Console.WriteLine("Choose a category: Personal, Work, Ideas, Gratitude, Other");
                    string category = Console.ReadLine();                    
                    myJournal.AddEntry(new Entry(DateTime.Now.ToShortDateString(), prompt, response, category));
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.WriteLine("\nChoose a format to save:");
                    Console.WriteLine("1. Simple format (~|~)");
                    Console.WriteLine("2. CSV format (Excel compatible)");
                    Console.WriteLine("3. JSON format");

                    Console.Write("Enter your choice: ");
                    string formatChoice = Console.ReadLine();

                    Console.Write("Enter filename (without extension): ");
                    string filename = Console.ReadLine();

                    if (formatChoice == "1")
                    {
                        myJournal.SaveToFile(filename + ".txt");
                    }
                    else if (formatChoice == "2")
                    {
                        myJournal.SaveToCSV(filename + ".csv");
                    }
                    else if (formatChoice == "3")
                    {
                        myJournal.SaveToJSON(filename + ".json");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. The journal was not saved.");
                    }
                    break;

                case "4":
                    Console.Write("Enter filename: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
