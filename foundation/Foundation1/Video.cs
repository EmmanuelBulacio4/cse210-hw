using System;
public class Video
{
    public string _title;
    public string _creator;
    public int _lenght;

    public List<Comment> _comments = new List<Comment>();

    public string AddComment(string person, string text)
    {
        _comments.Add(person, text)
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_title}n\Author: {_creator}n\Lenght: {_lenght} seg");
        Console.WriteLine("Comments: ")
    }
        
        
}