using System;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    GoalManager()
    {
    }

    public void Start()
    {
        Goal goal = new();
        goal.SetGoal();
    }

    public void DisplayPlayerInfo()
    {

    }


    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++) {
            Console.Write($"{i + 1}. ");
            _goals[i].GetStringRepresentation();
            Console.Write("\n");
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void SaveGoals()
    {
        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();

        using (StreamWriter saveToFile = new StreamWriter(fileName))
        {
            int totalAGP = GetTotalPoints();
            saveToFile.WriteLine(totalAGP.ToString());
            
            foreach(Goal goal in _goals)
            {
                saveToFile.WriteLine(goal.SaveGoal());
            }
        }
    }
private int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void LoadGoals()
    {
        _goals.Clear(); 

        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _totalPoints = Convert.ToInt32(lines[0]);

        for (int i = 1; i < lines.Count(); i++ )
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal") {

                SimpleGoal simpleGoal = new(parts[1], parts[2], int.Parse(parts[3]), Convert.ToBoolean(parts[4]));
                _goals.Add(simpleGoal);             

            } else if (parts[0] == "EternalGoal") {

                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse((parts[3])));
                _goals.Add(eternalGoal);

            } else if (parts[0] == "ChecklistGoal") {
                
                CheckListGoal checklistGoal = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                _goals.Add(checklistGoal);

            }
        }

    }
}