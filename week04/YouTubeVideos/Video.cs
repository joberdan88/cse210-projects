public class Video
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Duration { get; private set; }
    private List<Comment> comments;

    //Constructors
    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
        comments = new List<Comment>();
    }

    //Methods 
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"\nTitle: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Duration: {Duration} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");

        foreach (var comment in comments)
        {
            Console.WriteLine($" - {comment}");
        }
    }
}