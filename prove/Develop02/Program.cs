using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        bool _loop = true;

        while (_loop == true)
        {
            Console.WriteLine($"Please select one of the following choices: {Environment.NewLine}1. Write{Environment.NewLine}2. Display{Environment.NewLine}3. Load{Environment.NewLine}4. Save{Environment.NewLine}5. Quit");
            Console.WriteLine("What would you like to do? ");
            int _election = int.Parse(Console.ReadLine());
            
            if (_election == 1) //Write an entry
            {
                    //Muestro una _prompt del GetPromptGEnerator
                    //Pido la respuesta del usuario
                    //Agrego a una lista
                Console.Write("You choose option 1!");
            }   
            else if (_election == 2) //Display the entry
            {
                Console.Write("You choose option 2!");
            }
            else if (_election == 3) //Load the txt file.
            {
                    //ask for the file name.
                    //save the name in a variable.
                    //The algorithm to save the data in a variable. 
                Console.Write("You choose option 3!");
            }
            else if(_election == 4) //Save your entries
            {
                 //ask for the file name.
                //save the name in a variable.
                //The algorithm to save the data in the txt file.
                //Format ($"{date} - {Prompt} - {answer}")
                Console.Write("You choose option 4!");
            }
            else
            {
                _loop = false;
            }
        }
    }
}
