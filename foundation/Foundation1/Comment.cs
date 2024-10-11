using System;

public class Comment
{
    public string _personName;
    public string _commentText;


    public Comment()
    {
        _personName = "Unknown";
        _commentText = "couldn't get comment."
    }
        
    public void GetVideoComment()
    {
        foreach (Comment comentario in _comments)
        {
            Console.WriteLine($"Person: {_pesonName}n\Comment: {_commentText}")
        }
    }
    } 