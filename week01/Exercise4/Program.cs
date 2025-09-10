using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int total = 0;
        double average = 0;
        int largest = 0;
        int smallest = int.MaxValue;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            if (input == "0")
            {
                break;
            }

            int number = int.Parse(input);

            numbers.Add(number);
            total += number;

            average = (double)total / numbers.Count;

            largest = numbers.Max();


            foreach (int num in numbers)
            {

                if ((num > 0) && (num < smallest))
                {
                    smallest = num;
                }
            }
        }

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}
