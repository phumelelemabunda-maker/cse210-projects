using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // ===== Video 1 =====
        Video v1 = new Video("Learn C# Basics", "Code Academy", 600);
        v1.AddComment(new Comment("Alice", "Very helpful!"));
        v1.AddComment(new Comment("Bob", "Great explanation."));
        v1.AddComment(new Comment("Charlie", "Loved it!"));

        // ===== Video 2 =====
        Video v2 = new Video("Morning Workout Routine", "Fitness Pro", 900);
        v2.AddComment(new Comment("David", "Feeling motivated!"));
        v2.AddComment(new Comment("Eve", "Nice routine."));
        v2.AddComment(new Comment("Frank", "Awesome!"));

        // ===== Video 3 =====
        Video v3 = new Video("Cooking Pasta Perfectly", "Chef John", 500);
        v3.AddComment(new Comment("Grace", "Tasty recipe!"));
        v3.AddComment(new Comment("Hannah", "Easy to follow."));
        v3.AddComment(new Comment("Ian", "Loved the tips!"));

        // Add videos to list
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        // ===== Display =====
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            Console.WriteLine("---- Comments ----");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}