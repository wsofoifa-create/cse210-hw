using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Learn C# in 20 Minutes", "Code Academy", 1200);

        video1.AddComment(new Comment("Alice", "This tutorial was very helpful!"));
        video1.AddComment(new Comment("Bob", "I finally understand classes."));
        video1.AddComment(new Comment("Charlie", "Please make more C# videos."));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 Travel Destinations", "Travel World", 840);

        video2.AddComment(new Comment("Emma", "Beautiful locations!"));
        video2.AddComment(new Comment("Noah", "Adding these to my vacation list."));
        video2.AddComment(new Comment("Sophia", "Amazing video quality."));
        video2.AddComment(new Comment("James", "I want to visit Japan!"));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Easy Homemade Pizza", "Kitchen Time", 620);

        video3.AddComment(new Comment("Olivia", "Made this tonight!"));
        video3.AddComment(new Comment("Liam", "Turned out delicious."));
        video3.AddComment(new Comment("Ava", "Very easy recipe."));
        video3.AddComment(new Comment("Ethan", "Can't wait to try it."));

        videos.Add(video3);

        // Video 4
        Video video4 = new Video("30 Minute Home Workout", "Fitness Pro", 1800);

        video4.AddComment(new Comment("Mia", "Great workout!"));
        video4.AddComment(new Comment("Lucas", "Perfect for beginners."));
        video4.AddComment(new Comment("Harper", "I feel exhausted!"));
        video4.AddComment(new Comment("Mason", "Thanks for sharing."));

        videos.Add(video4);

        // Display all videos
        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}