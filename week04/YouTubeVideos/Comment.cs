public class Comment
{
    //Atributes
    public string Author { get; private set; }
    public string Text { get; private set; }

    //Constructors
    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
    }

    //Method ToString
    public override string ToString()
    {
        return $"{Author}: {Text}";
    }
}

