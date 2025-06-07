public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity helps you relax by guiding your breathing.")
    {

    }
    public void Run()
    {
        DisplayStartingMessage();
        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountDown(3);
            Console.WriteLine("\nBreathe out...");
            ShowCountDown(3);
            elapsedTime += 6;
        }

        DisplayEndingMessage();
    }
}