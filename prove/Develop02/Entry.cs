using System.Dynamic;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _answer;
    
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _answer = entryText;
    }
    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText} - {_answer}");
    }

     public override string ToString()
    {
        return $"{_date} - {_promptText} - {_answer}";
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetPrompt()
    {
        return _promptText;
    }

    public string GetAnswer()
    {
        return _answer;
    }

}