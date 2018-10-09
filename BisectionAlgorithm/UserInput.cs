using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    class UserInput
    {
        public int InputTarget(int length)
        {
            int target;

            Console.WriteLine($"Enter a number between 1 and {length}");
            target = UtilityHandler.ErrorHandler(length);

            return target;

        }
    }
}
