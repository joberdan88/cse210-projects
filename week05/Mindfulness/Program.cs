using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1 - Breathing");
            Console.WriteLine("2 - Reflecting");
            Console.WriteLine("3 - Listing");
            Console.WriteLine("4 - Exit");
            Console.Write("Enter Choice: ");

            string choice = Console.ReadLine();

            if (choice == "4") break;

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectingActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
            }
        }

        Console.WriteLine("\nThank you for using the mindfulness program!");
    }
}