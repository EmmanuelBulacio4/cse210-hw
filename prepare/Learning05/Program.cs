using System;

class Program
{
    static void Main(string[] args)
    {
        //Instance the object tarea1
        Assignment tarea1 = new();
        
        //Set the student name
        tarea1.SetStudentName("Emmanuel Bulacio");
        
        //Set the topic
        tarea1.SetTopic("Slopes in functions");
        
        //Call Get Sumary method to show info
        Console.WriteLine(tarea1.GetSumary());

        //Test MathAssignment
        MathAssignment math1 = new MathAssignment("Emmanuel Bulacio", "Divisions", "7.9", "5 - 254");
        Console.WriteLine(math1.GetSumary());
        Console.WriteLine(math1.GetHomeworkList());


    }
    
}