using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    class UserNum
    {
        public void SearchNum(int[] arr, int target)
        {
            int guess;
            bool right = false;
            int counter = 0;

            Console.WriteLine($"Can you guess my number??? lets see.");
            Console.WriteLine("I'll tell you if your number is higher or lower than my number.");

            do
            {
                Console.WriteLine($"Enter a number between 1 and {arr.Length}");
                guess = UtilityHandler.ErrorHandler(arr.Length);

                right = FindNumber(target, guess);
                counter++;

            } while (!right);

            Console.WriteLine($"Good job it only took you {counter} guesses!");
            Console.ReadLine();
            Console.Clear();
        }



        private bool FindNumber(int target, int userGuess)
        {
            bool guessRight;

            if (userGuess < target)
            {
                Console.WriteLine("too low.");
                guessRight = false;
            }
            else if (userGuess > target)
            {
                Console.WriteLine("too high.");
                guessRight = false;
            }
            else
            {
                guessRight = true;
            }

            return guessRight;
        }
    }
}

