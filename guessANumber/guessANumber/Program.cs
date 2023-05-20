using System;

namespace guessANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 101);
            Console.Write("Guess a number (1-100): ");
            int myNumber = int.Parse(Console.ReadLine());

            while (myNumber != number)
            {
                if (myNumber > number)
                {
                    Console.WriteLine("Too High!");
                }
                else if (myNumber < number)
                {
                    Console.WriteLine("Too Low!");
                }
                Console.Write("Guess a number (1-100): ");
                myNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("You guessed it!");
        }
    }
}