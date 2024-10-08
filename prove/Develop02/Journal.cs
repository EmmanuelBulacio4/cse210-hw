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

    public void SaveToFile()
    {
        Console.WriteLine("Enter the filename; ");
        string fileName = Console.ReadLine();

        using (StreamWriter saveToFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            saveToFile.WriteLine("Date, Prompt, Answer");
            // You can use the $ and include variables just like with Console.WriteLine
            foreach (Entry entry in entries)
            {
                saveToFile.WriteLine($"{entry.GetDate()},{entry.GetPrompt()},{entry.GetAnswer()}");
            }
        }
    } 

    public void LoadFromFile()
    {
        Console.WriteLine("Write the name of the .txt file");
        string filename = Console.ReadLine();
        entries.Clear();

        using (StreamReader reader = new StreamReader(filename))
            {
                string headerLine = reader.ReadLine(); // It discard the header line

                while (!reader.EndOfStream)
                {
                    string entryLine = reader.ReadLine();
                    string[] fields = entryLine.Split(',');

                    string date = fields[0];
                    string prompt = fields[1].Replace(",,", ",");
                    string response = fields[2].Replace(",,", ",");

                    entries.Add(new Entry(prompt, response, date));
                }
            }

            Console.WriteLine("File Loaded succesfully");
    }
}  