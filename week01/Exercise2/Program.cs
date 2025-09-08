using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage?: ");
        string gradeFromUser = Console.ReadLine();
        string letter;
        string sign = "";


        int gradeNumber = int.Parse(gradeFromUser);

        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int remainder = gradeNumber % 10;

        if (gradeNumber >= 60 && gradeNumber < 97)
        {
            if (remainder >= 7)
            {
                sign = "+";
            }
            else if (remainder < 3)
            {
                sign = "-";
            }
        }
        else
        {
            sign = "";
        }
        

        Console.WriteLine();
        Console.WriteLine($"Your grade is {letter}{sign}.");


        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations! You Passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass. You can retake the course so you can pass next time.");
        }

        


    }

}