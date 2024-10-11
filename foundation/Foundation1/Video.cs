using System;
public class Video
{
    public string _title;
    public string _creator;
    public int _lenght;

    public List<Comment> _comments = new List<Comment>();

    public Video()
    {
    }
    
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CountComments()
    {
        int counter = 0;
        counter = _comments.Count();
        return counter;
    }

    public void Display()
    {
        Console.WriteLine("************************************************************************");
        Console.WriteLine($"Name: {_title} | Author: {_creator} | Lenght: {_lenght} seg");
        int commentCounter = CountComments();
        Console.WriteLine($"There are {commentCounter} comments.");
        Console.WriteLine("Comments: ");
    } 

    public void GetVideoComment()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetPersonName()}: {comment._commentText} ");
        }
    }  
}