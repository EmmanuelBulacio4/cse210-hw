using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "the best Homemade rocket stove";
        video1._creator = "McGiver";
        video1._lenght = 205;
        //List<Comment> video1Comments = new List<Comment>();
        Comment comment1 = new Comment ("Emma", "great work man.");
        video1.AddComment(comment1);
        Comment comment2 = new Comment ("Matheo", "Not only the best home made this looks better than ones you buy I would pay 150 USD for such a great design");
        video1.AddComment(comment2);
        Comment comment3 = new Comment ("unknown", "I´d rather buy a portable one and avoid all that useless tasks!");
        video1.AddComment(comment3);
        
        video1.Display();
        video1.GetVideoComment();

        Video video2 = new Video();
        video2._title = "Love you like a love song";
        video2._creator = "Selena Gomez & The Scene";
        video2._lenght = 265;
        //List<Comment> video1Comments = new List<Comment>();
        Comment comment4 = new Comment ("engellopez-rn9ft", "This song brings back memories that I never knew existed");
        video2.AddComment(comment4);
        Comment comment5 = new Comment ("Supriya-ew1nl", "This is literally one of the best songs of her");
        video2.AddComment(comment5);
        Comment comment6 = new Comment ("emmarecomba7257", "Takes me back , man. Good times, good memories, great experiences. Great songs");
        video2.AddComment(comment6);
        Comment comment7 = new Comment ("Lana S", "this song is always in my head! Selena must come to sing songs like this");
        video2.AddComment(comment7);
        
        video2.Display();
        video2.GetVideoComment();

         Video video3 = new Video();
        video3._title = "Will IA replace programmers?";
        video3._creator = "NeetCode";
        video3._lenght = 247;
        //List<Comment> video1Comments = new List<Comment>();
        Comment comment8 = new Comment ("NeetCode", "No, I don't think AI is going to take our jobs..  unless you don't subscribe, at that point anything can happen 😉");
        video3.AddComment(comment8);
        Comment comment9 = new Comment ("glaci1008", "This video really brightened my day. As a software eng. student, I was getting worried my efforts would amount to nothing after I get out of school. Liked and subscribed!");
        video3.AddComment(comment9);
        Comment comment10 = new Comment ("kswag", "I'm curious to see how GPT4 will compare to this. It's supposed improve on the current GPT3 greatly but we won't know until it is released");
        video3.AddComment(comment10);
        Comment comment11 = new Comment ("Gaby2005", "I was thinking about self-teaching, joining a bootcamp, or going back to college to become a software engineer. Based on some of these comments though, I don't know how stable this industry is anymore :(");

        video3.AddComment(comment11);
        
        video3.Display();
        video3.GetVideoComment();

    }
}