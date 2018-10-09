using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    class CompNum : FindNum
    {
        public void NumFinder(int[] arr, int answer)
        {
            int mid;
            int beginning = 1;
            int last = arr.Length;
            bool found = false;


            while (!found)
            {
                mid = (beginning + last) / 2;

                if (answer < mid)
                {
                    last = mid - 1;
                    Console.WriteLine($"{mid} is too high");
                }
                else if (answer > mid)
                {
                    beginning = mid + 1;
                    Console.WriteLine($"{mid} is too low");
                }
                else
                {
                    found = true;
                    Console.WriteLine("Number Found!");
                    Console.WriteLine($"{answer} is your answer");
                }

            }

            Console.ReadLine();
            Console.Clear();
        }

        public void Assist(int[] arr, int target)
        {
            int first = 1;
            int last = arr.Length;
            int midpoint;
            string answer = "";
            bool found = false;
            bool rightAnswer = false;
            int counter = 0;

            Console.WriteLine("Please tell me whether it is 'High', 'Low', or 'Correct'...");

            do
            {
                midpoint = (first + last) / 2;
                Console.WriteLine($"Is your number {midpoint}?");
                answer = Console.ReadLine();

                if (answer == "High" || answer == "Low" || answer == "Correct")
                {
                    rightAnswer = true;
                }

                while (!rightAnswer)
                {
                    Console.WriteLine(" enter 'High', 'Low', or 'Correct'.");
                    answer = Console.ReadLine();
                    if (answer == "High" || answer == "Low" || answer == "Correct")
                    {
                        rightAnswer = true;
                    }
                }

                if (answer == "High")
                {
                    last = midpoint - 1;
                    found = false;
                }
                else if (answer == "Low")
                {
                    first = midpoint + 1;
                    found = false;
                }
                else if (answer == "Correct")
                {
                    found = true;
                }

                rightAnswer = false;
                counter++;
            } while (!found);

            Console.WriteLine($"Your number was found after {counter} tries.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
