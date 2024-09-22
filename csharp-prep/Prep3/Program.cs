using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,101);
        
        int counter = 0;
        int guessedNumber = -1;

        while (guessedNumber != randomNumber)
        {
        Console.Write("Guess the number ");
        guessedNumber = int.Parse(Console.ReadLine());
        counter ++;
        if (guessedNumber > randomNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (guessedNumber < randomNumber)
        {
            Console.WriteLine("Higher");
        }
        else{
            Console.WriteLine($"You guessed it");
        }}
    }
}