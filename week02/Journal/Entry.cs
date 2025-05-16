public class Entry
{
    public string _text;
    public DateTime _date;

    public void Display()
    {
        Console.WriteLine($"{_date.ToShortDateString()} - {_text}");
    }
}
