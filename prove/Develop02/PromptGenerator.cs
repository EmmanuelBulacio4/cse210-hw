using System.Diagnostics.Metrics;

public class PrompGenerator
{
    public static string GetRamdomPrompt()
    {
        List<string> prompts = [
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
        int index = rnd.Next(prompts.Count);

        // Print random fruit
        string election = prompts[index];
        return election;
    }
}