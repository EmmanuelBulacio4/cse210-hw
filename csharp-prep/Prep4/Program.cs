using System;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();

        int number = -1;

        //Ask for numbers to the user.
        while (number != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        //Sum the numbers in the list.

        int sumTotal = 0;
        foreach (int num in numbers)
            {
                sumTotal += num;
            }

        //Calculate the average.
        int amountNumbers = numbers.Count;

        float average = sumTotal/amountNumbers;

        //Get the largest number

        int max = numbers.Max();

        //Print the sum, average and the largest number.
        Console.WriteLine($"The sum is: {sumTotal}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

    }
}