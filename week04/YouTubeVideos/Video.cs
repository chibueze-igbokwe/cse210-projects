using System.Collections.Generic;

// Represents a YouTube video
public class Video
{
    // Properties of the video
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // in seconds

    // List to store comments
    private List<Comment> _comments = new List<Comment>();

    // Constructor
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Method to display all comments
    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"   {comment.CommenterName}: {comment.CommentText}");
        }
    }
}