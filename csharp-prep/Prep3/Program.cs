using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Whats is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessNumber = -1;

        while (magicNumber != guessNumber) 
        {
            Console.WriteLine("What is your guess? ");
            string userGuessEntry = Console.ReadLine();
            guessNumber = int.Parse(userGuessEntry);

            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if(guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } 

    }
}