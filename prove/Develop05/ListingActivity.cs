using System;
public class ListingActivity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
         Console.Clear();
        Console.WriteLine("Welcome to the Listing Activity.\n");
        Console.WriteLine("Mensaje de la listing Activity");
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