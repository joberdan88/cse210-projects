using System.Collections.Generic;
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity helps you list positive things in life.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine($"\n{_prompts[new Random().Next(_prompts.Count)]}");
        ShowSpinner(3);

        List<string> responses = new List<string>();
        int elapsedTime = 0;

        while (elapsedTime < _duration)
        {
            Console.Write("Enter a response: ");
            responses.Add(Console.ReadLine());
            elapsedTime += 5;
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        DisplayEndingMessage();
    }
}
