using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("Top 10 Gadgets", "TechWorld", 600);
        Video video2 = new Video("Gaming Laptop Review", "GameZone", 840);
        Video video3 = new Video("Phone Camera Test", "MobileDaily", 420);


        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Loved the breakdown."));


        video2.AddComment(new Comment("Dave", "Thinking of buying this."));
        video2.AddComment(new Comment("Eve", "Nice review."));
        video2.AddComment(new Comment("Frank", "Benchmarks were solid."));


        video3.AddComment(new Comment("Grace", "Camera quality looks great."));
        video3.AddComment(new Comment("Hank", "Low light test was useful."));
        video3.AddComment(new Comment("Ivy", "Which phone is this?"));


        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };


        foreach (Video video in videos)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
