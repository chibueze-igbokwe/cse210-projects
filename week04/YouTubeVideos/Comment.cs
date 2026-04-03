// Represents a single comment on a video
public class Comment
{
    // Property to store the commenter's name
    public string CommenterName { get; set; }

    // Property to store the comment text
    public string CommentText { get; set; }

    // Constructor to initialize a comment
    public Comment(string name, string text)
    {
        CommenterName = name;
        CommentText = text;
    }
}