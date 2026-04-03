using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // -----------------------------
        // Create Video 1
        Video video1 = new Video("Learn C# Basics", "CodeMaster", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Can you do advanced topics?"));

        // Create Video 2
        Video video2 = new Video("OOP Explained", "DevGuru", 800);
        video2.AddComment(new Comment("David", "Now I understand classes!"));
        video2.AddComment(new Comment("Eva", "Well explained."));
        video2.AddComment(new Comment("Frank", "More examples please."));

        // Create Video 3
        Video video3 = new Video("ASP.NET Intro", "WebDevPro", 900);
        video3.AddComment(new Comment("Grace", "Nice intro."));
        video3.AddComment(new Comment("Henry", "Very clear."));
        video3.AddComment(new Comment("Ivy", "Waiting for part 2!"));

        // Add videos to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // -----------------------------
        // Display all videos and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            video.DisplayComments();
        }
    }
}