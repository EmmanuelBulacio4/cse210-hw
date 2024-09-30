using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        
        Entry anEntry = new Entry();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Console.WriteLine("Welcome to the Journal Program!");
        bool _loop = true;
        

        while (_loop == true)
        {
            Console.WriteLine($"Please select one of the following choices: {Environment.NewLine}1. Write{Environment.NewLine}2. Display{Environment.NewLine}3. Load{Environment.NewLine}4. Save{Environment.NewLine}5. Quit");
            Console.WriteLine("What would you like to do? ");
            int _election = int.Parse(Console.ReadLine());
            
            if (_election == 1) //Write an entry
            {
                string question = PrompGenerator.GetRamdomPrompt(); //It renders on console.
                Console.WriteLine(question);
                Console.WriteLine("Write your answer: "); //It renders on console.
                
                //Create a new entry to the journal.
                anEntry._date = dateText;
                anEntry._entryText = Console.ReadLine();
                anEntry._promptText = question; 
                
                //Add an entry to the journal.
                theJournal._entries.Add(anEntry); 
            }   
            else if (_election == 2) //Display the entry
            {
                anEntry.Display();
            }
            else if (_election == 3) //Load the txt file.
            {
                string filename = "myFile.txt";
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    string date = parts[0];
                    string prompt = parts[1];
                    string answer = parts[2];
                }
            }
            else if(_election == 4) //Save your entries
            {
                Console.Write("You choose option 4!");
            }
            else
            {
                _loop = false;
            }
        }
    }
}
