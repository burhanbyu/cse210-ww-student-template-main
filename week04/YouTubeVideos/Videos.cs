using System;

class Video
{
    public string Title;
    public string Author;
    public int LengthInSeconds;

    private Comment[] comments = new Comment[10];
    private int commentCount = 0;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        LengthInSeconds = length;
    }

    public void AddComment(Comment comment)
    {
        comments[commentCount] = comment;
        commentCount++;
    }

    public int GetNumberOfComments()
    {
        return commentCount;
    }

    public Comment[] GetComments()
    {
        Comment[] result = new Comment[commentCount];

        for (int i = 0; i < commentCount; i++)
        {
            result[i] = comments[i];
        }

        return result;
    }
}