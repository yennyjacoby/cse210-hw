using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        //Typing journal, will have access to the journal.cs
        Journal journal = new Journal();
        
        bool running = true;

        while (running)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            string choice = Console.ReadLine();
        

            if (choice == "1")
            {
                journal.StoreEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                journal.LoadFile();
            }
            else if (choice == "4")
            {
                journal.SaveFile();
            }
            else if (choice == "5")
            {
                running =  false;
            }
            else
            {
                Console.WriteLine("Please try again.");
            }
        }
    }
}