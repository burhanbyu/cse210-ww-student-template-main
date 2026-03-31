using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("How to Cook Pasta", "Chef John", 300);
        Video video2 = new Video("Top 10 Coding Tips", "Jane Doe", 600);
        Video video3 = new Video("Yoga for Beginners", "FitnessGuru", 900);
        Video video4 = new Video("Travel Vlog: Paris", "Traveler Mike", 720);

        // Add comments
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "I love pasta!"));
        video1.AddComment(new Comment("Charlie", "Easy to follow."));

        video2.AddComment(new Comment("Dave", "Very helpful tips."));
        video2.AddComment(new Comment("Eve", "Thanks for sharing."));
        video2.AddComment(new Comment("Frank", "I learned a lot."));

        video3.AddComment(new Comment("Grace", "Perfect for beginners."));
        video3.AddComment(new Comment("Hannah", "Loved the flow."));
        video3.AddComment(new Comment("Ian", "Will do this daily."));

        video4.AddComment(new Comment("Jack", "Amazing footage!"));
        video4.AddComment(new Comment("Karen", "I want to visit Paris now."));
        video4.AddComment(new Comment("Leo", "Beautiful video!"));

        // Store videos in an array
        Video[] videos = { video1, video2, video3, video4 };

        // Display videos
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.LengthInSeconds + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.Name + ": " + comment.Text);
            }

            Console.WriteLine();
        }
    }
}