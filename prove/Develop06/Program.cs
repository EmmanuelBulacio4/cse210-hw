using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalsList = new GoalManager();
        
        bool _loop = true;
        while (_loop == true)
        {
            Console.WriteLine($"Please select one of the following choices: \n1. Create a New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("What would you like to do? ");
            int _election = int.Parse(Console.ReadLine());
            
            
            
            if (_election == 1) //Create New Goals
            {
                Console.WriteLine(" 1. Simple Goal.\n 2. Eternal Goal.\n 3. Checklist Goal.");
                int kind = int.Parse(Console.ReadLine());
                if (kind == 1)
                {
                    Goal newSimple = new SimpleGoal();
                    newSimple.SetGoal();
                    goalsList.AddGoal(newSimple);
                }
                else if (kind == 2)
                {
                    Goal newEternal = new EternalGoal();
                    newEternal.SetGoal();
                    goalsList.AddGoal(newEternal);
                }

                else if (kind == 3)
                {
                    Goal newCheck = new CheckListGoal();
                    newCheck.SetGoal();
                    goalsList.AddGoal(newCheck);
                }
                else
                {
                    Console.WriteLine("Please, enter a correct answer. Values among 1 - 3.");
                }
            }
            
            else if (_election == 2) //List Goals.
            {
                goalsList.ListGoal();
            }

            else if (_election == 3) //Save Goals
            {
                goalsList.SaveGoals();
            }
            else if(_election == 4) //Load Goals
            {
                goalsList.LoadGoals();
            }

            else if(_election == 5) //Record Event
            {
                goalsList.ManagerRecordEvent();
            }

            else //Quit
            {
                _loop = false;
            }
        }
    }
}