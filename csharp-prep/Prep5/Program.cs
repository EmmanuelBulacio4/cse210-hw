using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int favNumber = PromptUserNumber();

        int calculatedNumber = SquareNumber(favNumber);

        DisplayResult(userName, calculatedNumber);


    static void DisplayWelcome()
    {
        Console.Write("Welcome to the Program!");
    }


    static string PromptUserName()
    {
        Console.WriteLine("Enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }

    static int SquareNumber(int userInput)
    {
        int squareNumber = userInput*userInput;

        return squareNumber;
    }

    static void DisplayResult(string name, int square)
    {
        Console.Write($"{name}, the square of your number is {square}.");
    }
    }
}
