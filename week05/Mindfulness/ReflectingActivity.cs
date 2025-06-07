using System.Collections.Generic;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you overcame a big challenge."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?"
    };

    public ReflectingActivity() : base("Reflectin", "This activity helps you reflect on personal strengths.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine($"\n{_prompts[new Random().Next(_prompts.Count)]}");
        ShowSpinner(3);

        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.WriteLine($"\n{_questions[new Random().Next(_questions.Count)]}");
            ShowSpinner(5);
            elapsedTime += 5;
        }

        DisplayEndingMessage();
    }
}
