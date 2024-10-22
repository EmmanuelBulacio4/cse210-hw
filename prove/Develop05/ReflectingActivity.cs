using System;
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    ReflectingActivity()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Reflecting Activity.\n");
        Console.WriteLine(".");
    }

    public void Run()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int _duration = int.Parse(Console.ReadLine());
    }

    public string GetRandomPrompt()
    {
        List<string> prompts = [
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."];
        
        // Random object
        Random rnd = new Random();

        // Get random index
        int index = rnd.Next(prompts.Count);

        // Print random fruit
        string prompt = prompts[index];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        List<string> questions = [
        "Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?", 
        "If I had one thing I could do over today, what would it be?",
        "What was an important momento today and why?",
        "Did you help out somebody today?",
        "What is the most importan lesson you learnd?",
        "What did you learn today and you like you children remember?"];
        
        // Random object
        Random rnd = new Random();

        // Get random index
        int index = rnd.Next(questions.Count);

        // Print random fruit
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
