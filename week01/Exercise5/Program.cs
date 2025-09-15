using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string userName = PromptUserName();
        int faveNumberInt = PromptUserNumber();
        int square = SquareNumber(faveNumberInt);

        DisplayResult(userName, square);


    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string faveNumber = Console.ReadLine();
        int faveNumberInt = int.Parse(faveNumber);
        return faveNumberInt;
    }

    static int SquareNumber(int faveNumberInt)
    {
            
        int square = faveNumberInt * faveNumberInt;
        return square;
    }

    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
    }

    
}