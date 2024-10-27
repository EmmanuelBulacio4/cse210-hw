using System;
public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int _totalPoints;

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
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.GetName());
        }
        //aqui seguro que es hacer un loop foreach y llamar el metodo que me devuelva el nombre.
    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }


}//Curlybrace final de la clase.