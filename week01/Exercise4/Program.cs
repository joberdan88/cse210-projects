using System;
using System.Collections.Generic;
using System.Linq;

class Program       
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }
        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = numbers.Average();
            int maxNumber = numbers.Max();

            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The average is {average}");
            Console.WriteLine($"The largest number is {maxNumber}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}


