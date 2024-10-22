using System;
public class ListingActivity : Activity
{
    //private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        SetName("Welcome to the Listing Activity.");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int _duration = int.Parse(Console.ReadLine());
    }

    public void GetRandomPrompt()
    {

    }

    // public List<string> GetListFromUser()
    // {
    //     retur
    // }

}