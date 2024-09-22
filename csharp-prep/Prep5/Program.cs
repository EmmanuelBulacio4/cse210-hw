using System;

class Program
{
    static void Main(string[] args)
    {
        //Mostrar mensaje de bienvenida
        DisplayMessage();

        //Pedir nombre del usuario y mostrarlo
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        DisplayPersonalMessage(userName);

        //Pedir el numero favorito y mostrarlo
        Console.Write("Enter you favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
               
        //Mostrar la raiz cuadrada del numero favorito
        int square = SquareNumber(favoriteNumber);
        Console.WriteLine($"{userName}, the square of your number is {square}.");
        //FUNCIONES

    static void DisplayMessage()
    {
    Console.WriteLine("Welcome to the program!");
    }

    static void DisplayPersonalMessage(string userName)
    {
    Console.WriteLine($"Hello {userName}");
    }

    static int SquareNumber (int number)
    {
        int square = number*number;
        return square;
    }

}//Cierre de la funcion main.
}//Cierre de Clase