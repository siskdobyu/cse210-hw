using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        string response = "yes";



        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        Random randomGenerator = new Random();
        
        while (response == "yes")
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();

            if (response != "yes")
            {
                Console.WriteLine("Goodbye!");
                break; // exit outer loop immediately
            }

            int number = randomGenerator.Next(1, 101);
            string guess;
            int guessInt;
            int guesscount = 0;

            do
            {

                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                // int magicNumberInt = int.Parse(magicNumber);
                guessInt = int.Parse(guess);
                guesscount++;

                if (guessInt < number)
                {
                    Console.WriteLine("Higher");

                }
                else if (guessInt > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You made {guesscount} guesses.");

                }
            } while (guessInt != number);           


        }
    }
}