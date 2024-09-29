using System.Diagnostics.Metrics;

public class PrompGenerator
{
    public List<string>_prompts = ["Who was the most interesting person I interacted with today?",
    "What was the best part of my day?", "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?","If I had one thing I could do over today, what would it be?"];

    static void GetRandomPrompt(string _prompts)
    {
        //This only works with a list with five elements. I shoud be inproved!!!
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(1, 5);

        Console.WriteLine(_prompts[index]);
    }
}