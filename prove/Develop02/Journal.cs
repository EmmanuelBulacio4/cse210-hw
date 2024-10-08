using System.Formats.Asn1;
using System.IO; 
public class Journal
{
    public List<Entry> entries;
    
    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt)
    {
        Console.WriteLine(prompt + " ");
        string _answer = Console.ReadLine();
        string date = DateTime.Now.ToString("MM/dd/yyy");
        entries.Add(new Entry(prompt, _answer, date));

    }

     public void DisplayAll()
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }

    public void SaveToFile(string file)
    {
        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("Date, Prompt, Answer");
            // You can use the $ and include variables just like with Console.WriteLine
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"");
            }
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