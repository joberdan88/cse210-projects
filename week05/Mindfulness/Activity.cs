using System;
using System.Threading;

public abstract class Activity
{

    protected string _name;
    protected string _description;
    protected int _duration;

    //Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    //Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name} activity!");
        Console.WriteLine(_description);
        Console.Write("\nEnter the duration in seconds:");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready... ");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGreat job! You've completed the activity.");
        Console.WriteLine($"You spent {_duration} seconds on {_name}");
        ShowSpinner(3);
    }


    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(". ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }


    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i < 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }    
}