using System;
using System.Collections.Generic;

public class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> Comments { get; set; } = new List<Comment>();

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (var comment in Comments)
        {
            Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
        }

        Console.WriteLine(new string('-', 50));
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video
        {
            Title = "Love the Philippines",
            Author = "Tourism Philippines",
            LengthInSeconds = 134
        };
        video1.AddComment(new Comment("Juan", "This is amazing!"));
        video1.AddComment(new Comment("John", "I love it."));
        video1.AddComment(new Comment("Jane", "Nice!"));

        Video video2 = new Video
        {
            Title = "Siblings | Animated Short Film | Kenet Garcia Rojas",
            Author = "KenetBear",
            LengthInSeconds = 223
        };
        video2.AddComment(new Comment("Ann", "So touching."));
        video2.AddComment(new Comment("Mary", "Very heartwarming"));
        video2.AddComment(new Comment("Mark", "Great animation!"));

        Video video3 = new Video
        {
            Title = "Who are you?",
            Author = "Our Animated Box",
            LengthInSeconds = 811
        };
        video3.AddComment(new Comment("Larry", "Enlightening!"));
        video3.AddComment(new Comment("Jennifer", "Love this."));
        video3.AddComment(new Comment("Ellaine", "This makes sense."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
