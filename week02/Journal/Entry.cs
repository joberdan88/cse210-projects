public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _category;

    public Entry(string date, string prompt, string response, string category)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        _category = category;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - [{_category}] {_prompt}");
        Console.WriteLine($"Response: {_response}");
    }
}
