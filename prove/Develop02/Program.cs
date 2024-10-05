using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        //Star a new JOurnal
        Journal theJournal = new Journal();

        //Date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        //Start the program on console
        Console.WriteLine("Welcome to the Journal Program!");
        
        bool _loop = true;
        while (_loop == true)
        {
            Console.WriteLine($"Please select one of the following choices: {Environment.NewLine}1. Write{Environment.NewLine}2. Display{Environment.NewLine}3. Load{Environment.NewLine}4. Save{Environment.NewLine}5. Quit");
            Console.Write("What would you like to do? ");
            int _election = int.Parse(Console.ReadLine());
            
            if (_election == 1) //Write an entry
            {
                string question = PrompGenerator.GetRamdomPrompt(); //It renders on console.
                Console.Write("Write your answer: "); //It renders on console.
                string answer = Console.ReadLine();
                
                //Add an entry to the journal.
                theJournal.AddEntry(dateText, question, answer); 
            }   
            else if (_election == 2) //Display the entry
            {
                theJournal.DisplayAll();
            }
            else if (_election == 3) //Load the txt file.
            {
                
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
