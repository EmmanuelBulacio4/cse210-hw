using System;

class Program
{
    static void Main(string[] args)
    {
        bool mainLoop = true;
        while (mainLoop == true)
        {
            Console.WriteLine("Menu Options:\n 1.Start Breathing activit0y\n 2.Star Reflecting activity\n 3.Star Listing activity\n 4.Quit\nEnter your choose:");
            int election = int.Parse(Console.ReadLine());

            if (election == 1)
            {
                Console.Clear();
                //Mensaje de Bienvenida del BReathing.
                Console.WriteLine("Option 1");
            }
            else if (election == 2)
            {
                Console.WriteLine("Option 2");
            }
            else if(election == 3)
            {
                Console.WriteLine("Option 3");
            }
            else
            {
                mainLoop = false;
            }
        }
        
    }
} 