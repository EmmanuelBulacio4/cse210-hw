using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string gradeInput = Console.ReadLine();
        int gradeFromUser = int.Parse(gradeInput);

        string letter = "";
        string sign = "";

        if (gradeFromUser >= 90)
        {
            letter = "A";
            //Console.WriteLine("You have an A. Congrats, You pass the class!");
        }
        else if (gradeFromUser >=80 && gradeFromUser <=89)
        {
            letter = "B ";
            //Console.WriteLine("You have a B. Congrats, You pass the class!");
        }
        else if (gradeFromUser >=70 && gradeFromUser <=79)
        {
            letter = "C";
            //Console.WriteLine("You have a C. Congrats, You pass the class!");
        }
        else if (gradeFromUser >=60 && gradeFromUser <=69)
        {
            letter = "D";
            //Console.WriteLine("You have a D.");
        }
        else
        {
            letter = "F";
            //Console.Write("You have an F.");
        }

    int valueToSign = gradeFromUser%10;

    if(letter != "A" && letter != "F")
    {
        if (valueToSign <= 3)
        {
            sign = "-";
        }
        else if (valueToSign >= 7)
        {
            sign = "+";
        }
        else{
            sign = "";
        }
    }
    else if (letter == "A")
    {
        if (valueToSign <= 3)
        {
            sign = "-";
        }
        else{

        }
    }
    else
    {
        letter = "F";
        sign = "";
    }

    Console.WriteLine($"Your grade is {letter}{sign}.");

        //Console.WriteLine(letter);
    }
}