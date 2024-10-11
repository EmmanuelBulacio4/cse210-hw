using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "escribir un titulo despues";
        video1._creator = "escribir el autor despues";
        video1._lenght = 205;
        List<Comment> _video1Comments = new;
        _video1Comments.AddComment("Emma", "That is awesome!!")
        _video1Comments.AddComment("Louis", "great work man!")
        _video1Comments.AddComment("Unknown", "I need to try this!!")

        video1.Display();
        _video1Comments.GetVideoComment();

    }
}