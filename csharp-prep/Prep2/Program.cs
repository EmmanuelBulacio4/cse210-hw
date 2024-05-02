using System;

class Program
{
    static void Main(string[] args)
    { 
        Console.Write("What is your grade percentage? ");
        string userEntry = Console.ReadLine();
        int percentage = int.Parse(userEntry);

        if (percentage > 90)
        {
            Console.WriteLine("You have an A");
            Console.Write("You pass the course. Congrats!");
        }
        else if (percentage <90 && percentage>= 80)
        {
            Console.WriteLine("You have a B");
            Console.Write("You pass the course. Congrats!");
        }
        
        else if (percentage < 80 && percentage >= 70)
        {
            Console.WriteLine("You have a C.");
            Console.Write("You pass the course. Congrats!");
        }
        else if (percentage < 70 && percentage>=60)
        {
            Console.WriteLine("You have a D");
            Console.Write("You don´t pass. Study more next time.");
        }
        else
        {
            Console.Write("You have an F");
            Console.Write("You don´t pass. Study more next time.");
        }

    }
}