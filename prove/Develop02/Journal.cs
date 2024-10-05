using System.IO; 
public class Journal
{
    public List<Entry> _entry = new List<Entry>();

    public void AddEntry(Entry string dateText, string question, string answer)
    {
        Entry _entry = new Entry();
                _entry._date = dateText;
                _entry._entryText = answer;
                _entry._promptText = question; 

    }

    public void DisplayAll()
    {
        foreach(Entry i in _entry)
        {
            DisplayAll();
        }
    }

    public void SaveToFile(string file)
    {
        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }
    } 

    public void LoadFromFile(string file)
    {
        Console.WriteLine("Write the name of the .txt file");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string prompt = parts[1];
            string answer = parts[2];
        }
    }
} 