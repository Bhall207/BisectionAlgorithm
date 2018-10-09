using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            int target;
            Random ran = new Random();
            UserInput input = new UserInput();


            int[] numlist = new int[10];

            for (int i = 0; i < numlist.Length; i++)
            {
                numlist[i] = i + 1;
            }

            target = input.InputTarget(numlist.Length);

            FindNum finder = new CompNum();
            finder.NumFinder(numlist, target);


            int[] numList2 = new int[100];
            for (int i = 0; i < numList2.Length; i++)
            {
                numList2[i] = i + 1;
            }

            target = ran.Next(1, numList2.Length);

            UserNum userFinder = new UserNum();
            userFinder.SearchNum(numList2, target);

          
            target = input.InputTarget(numList2.Length);

            finder.Assist(numList2, target);

        }
    }
}
