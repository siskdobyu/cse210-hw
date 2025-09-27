using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        promptGenerator generator = new promptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Entry entry = new Entry();
                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptText = generator.getRandomPrompt();
                    Console.WriteLine(entry._promptText);
                    Console.Write("Your response: ");
                    entry._entryText = Console.ReadLine();
                    journal.addEntry(entry);
                    break;

                case "2":
                    journal.displayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "4":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SavetoFile(saveFile);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;


            }
        }
    }
}