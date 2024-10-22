using System;
public class ListingActivity : Activity
{
    //private int _count;
    private List<string> _prompts = new List<string>
        {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };

    public ListingActivity()
    {
        SetName("Welcome to the Listing Activity.");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayDurationTime();
        GetReady();

        
    }

    public string GetRandomPrompt()
    {
        List<string> prompts = _prompts;   
        
        Random rnd = new Random();

        int index = rnd.Next(prompts.Count);

        string prompt = prompts[index];
        return prompt;
    }

    public string GetPrompt()
    {
        return GetRandomPrompt();
    }

    // public List<string> GetListFromUser()
    // {
    //     retur
    // }

}