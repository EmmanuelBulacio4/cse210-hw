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
                List<Goal> goalsList = new List<Goal>();

                Console.WriteLine("1. Simple Goal.\n2. Eternal Goal.\n3. Checklist Goal.");
                int kind = int.Parse(Console.ReadLine());
                if (kind == 1)
                {
                    SimpleGoal newSimple = new SimpleGoal();
                    newSimple.SetGoal();
                    goalsList.Add(newSimple);
                }
                else if (kind == 2)
                {
                    EternalGoal newEternal = new EternalGoal();
                    newEternal.SetGoal();
                    goalsList.Add(newEternal);
                }

                else if (kind == 3)
                {
                    CheckListGoal newCheck = new CheckListGoal();
                    newCheck.SetGoal();
                    goalsList.Add(newCheck);
                }
                else
                {
                    Console.WriteLine("Please, enter a correct answer. Values among 1 - 3.");
                }
            }   
            else if (_election == 2) //List Goals
            {
                Console.WriteLine("Here you´ll see the list of goals!\n");
            }
            else if (_election == 3) //Save Goals
            {
                Console.WriteLine("Here you will save the list of goals.\n");
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