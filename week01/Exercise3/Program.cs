using System;

class Program
{
    static void Main(string[] args)
    {

        // User choosing the magic Number
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        int guess = 0;

        // loop
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it");
                
            }
        }

    }
}