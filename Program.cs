using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                PlayGame();
                Console.WriteLine("Do you wish to play again? Enter yes or no");
                String action = Console.ReadLine();
                if (action !="yes")
                {
                    Environment.Exit(0);
                }
            }
        }
        static void PlayGame()
        {
            Random random = new Random();
            int num = random.Next(1, 100); 
            int guessCount = 0;
            while (true)
            {
                Console.WriteLine("Enter a random number from 1 to 100:");
                int guess = Convert.ToInt32(Console.ReadLine());
                guessCount++;
                if (guess < num)
                {
                    Console.WriteLine("Sorry, Too Low");
                }
                else if (guess > num)
                {
                    Console.WriteLine("Sorry, Too high");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    break;
                }
            }
            Console.WriteLine("Total number of guesses required were: " + guessCount);
        }
    }
}
