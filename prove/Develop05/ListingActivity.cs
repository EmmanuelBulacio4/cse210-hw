using System;
public class ListingActivity : Activity
{
    private int _count;
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
        GetListFromUser();
        
        //Escribir frase de "Escribiste TANTAS frases en TANTOS segundos.

        //Mostrar mensaje final

    }

    public void SetCount(int count)
    {
        _count = count;
    }

    public int GetCount()
    {
        return _count;
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

    public void GetListFromUser()
    {
        string prompt = GetPrompt();

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (startTime <= endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            startTime = DateTime.Now;
        }
    }
}