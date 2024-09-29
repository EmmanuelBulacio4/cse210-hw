public class Entry
{
    DateTime theCurrentTime = DateTime.Now;
    string _date = theCurrentTime.ToShortDateString();

    public string _promptText = "";
    public string _entryText = "";

    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText} - {_entryText}");
    }
}