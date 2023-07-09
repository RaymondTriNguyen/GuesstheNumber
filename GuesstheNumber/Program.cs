using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool PlayAgain = false;
            do
            {



                Random random = new Random();
                int secretNumber = random.Next(1, 101);
                int attempts = 0;
                bool isCorrect = false;
                Console.WriteLine("Welcome to the random number game!");
                Console.WriteLine("I am thinking of a number from 1-100. Enter your guess.");

                //  bool play;
                while (!isCorrect)
                {
                    attempts++;

                    string input = Console.ReadLine();
                    int guess;

                    if (int.TryParse(input, out guess))
                    {
                        if (guess < secretNumber)
                        {
                            Console.WriteLine("Nope, too low! Try again!");
                        }
                        else if (guess > secretNumber)
                        {
                            Console.WriteLine("Nope, too high! Try again!");
                        }

                        else
                        {
                            isCorrect = true;
                        }

                    }

                    else
                    {
                        Console.WriteLine("That's not a whole number!");
                    }

                }

                Console.WriteLine("Congratulations, you completed the game! The secret number was " + secretNumber + ". You took " + attempts + " attempts. Do you want to play again ('yes' or 'no')");
                string playAgain = Console.ReadLine();
                if (playAgain == "yes")
                {
                    PlayAgain = true;
                }
                else { PlayAgain = false; }
                //tring playAgain = Console.ReadLine();
            }
            while (PlayAgain==true);
    }
    }
}