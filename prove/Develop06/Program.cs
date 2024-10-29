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
            
            GoalManager goalsList = new GoalManager();
            if (_election == 1) //Create New Goals
            {
                Console.WriteLine("1. Simple Goal.\n2. Eternal Goal.\n3. Checklist Goal.");
                int kind = int.Parse(Console.ReadLine());
                if (kind == 1)
                {
                    SimpleGoal newSimple = new SimpleGoal();
                    newSimple.SetGoal();
                    goalsList.AddGoal(newSimple);
                }
                else if (kind == 2)
                {
                    EternalGoal newEternal = new EternalGoal();
                    newEternal.SetGoal();
                    goalsList.AddGoal(newEternal);
                }

                else if (kind == 3)
                {
                    CheckListGoal newCheck = new CheckListGoal();
                    newCheck.SetGoal();
                    goalsList.AddGoal(newCheck);
                }
                else
                {
                    Console.WriteLine("Please, enter a correct answer. Values among 1 - 3.");
                }
            }   
            else if (_election == 2) //List Goals
            {
                goalsList.ListGoalNames();
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