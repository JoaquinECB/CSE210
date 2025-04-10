using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Crear lista de videos
        List<Video> videos = new List<Video>();

        // Crear y agregar videos con comentarios
        Video video1 = new Video("Learn C#", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));
        videos.Add(video1);

        Video video2 = new Video("Master Python", "Jane Smith", 900);
        video2.AddComment(new Comment("Dave", "This was super clear!"));
        video2.AddComment(new Comment("Eve", "Python is awesome!"));
        video2.AddComment(new Comment("Frank", "Thanks for the tips."));
        videos.Add(video2);

        Video video3 = new Video("Java Basics", "Mike Johnson", 750);
        video3.AddComment(new Comment("Grace", "Very detailed explanation."));
        video3.AddComment(new Comment("Hank", "I finally understand Java."));
        video3.AddComment(new Comment("Ivy", "Great for beginners!"));
        videos.Add(video3);

        // Mostrar información de cada video y sus comentarios
        foreach (Video video in videos)
        {
            Console.WriteLine($"\nVideo: {video.Title} by {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            video.DisplayComments();
        }
    }
}