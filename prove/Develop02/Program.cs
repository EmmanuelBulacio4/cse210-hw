using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        //Star a new Journal
        Journal theJournal = new Journal();

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
                theJournal.AddEntry(question);
            }   
            else if (_election == 2)
            {
                theJournal.DisplayAll();
            }
            else if (_election == 3) //Load the txt file.
            {
                //theJournal.LoadFromFile();
            }
            else if(_election == 4) //Save your entries
            {
                //theJournal.SaveToFile();
            }
            else
            {
                _loop = false;
            }
        }
    }
}
