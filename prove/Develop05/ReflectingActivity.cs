using System;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
        {
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."
        };
    private List<string> _questions = new List<string>
    {
        "Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?", 
        "If I had one thing I could do over today, what would it be?",
        "What was an important momento today and why?",
        "Did you help out somebody today?",
        "What is the most importan lesson you learnd?",
        "What did you learn today and you like you children remember?"
    };

    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayDurationTime();
        GetReady();

        Console.Clear();
        DisplayPrompt();
        ShowCountDown(9);
        DisplayQuestions();
        ShowSpinner(10);

        DisplayEndingMessage();


    }

    public string GetRandomPrompt()
    {
        List<string> prompts = _prompts;   
        
        Random rnd = new Random();

        int index = rnd.Next(prompts.Count);

        string prompt = prompts[index];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        List<string> questions = _questions;
        
        Random rnd = new Random();

        int index = rnd.Next(questions.Count);

        string question = questions[index];
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}
