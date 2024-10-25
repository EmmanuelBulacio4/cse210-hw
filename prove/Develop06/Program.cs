using System;

class Program
{
    static void Main(string[] args)
    {
         bool _loop = true;
        while (_loop == true)
        {
            Console.WriteLine($"Please select one of the following choices: \n1. Create a New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("What would you like to do? ");
            int _election = int.Parse(Console.ReadLine());
            
            if (_election == 1) //Create New Goals
            {
                
            }   
            else if (_election == 2) //List Goals
            {
                
            }
            else if (_election == 3) //Save Goals
            {
                
            }
            else if(_election == 4) //Load Goals
            {
                
            }

            else if(_election == 5) //Record Event
            {

            }

            else //Quit
            {
                _loop = false;
            }
        }
    }
}