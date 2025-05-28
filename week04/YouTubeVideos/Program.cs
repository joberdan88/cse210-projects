using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to code", "Jonas", 300);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot!"));

        Video video2 = new Video("Gaming Highlights", "Alex", 600);
        video2.AddComment(new Comment("David", "Awesome clips!"));
        video2.AddComment(new Comment("Emma", "Best moments ever!"));
        video2.AddComment(new Comment("Fiona", "Love this content!"));

        videos.Add(video1);
        videos.Add(video2);

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}