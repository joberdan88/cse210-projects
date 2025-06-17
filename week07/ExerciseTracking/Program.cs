using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new()
        {
            new Running(DateTime.Now, 30, 4.8),
            new Cycling(DateTime.Now, 45, 20),
            new Swimming(DateTime.Now, 25, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}