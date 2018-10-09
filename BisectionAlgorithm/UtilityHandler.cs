using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    class UtilityHandler
    {
        public static int ErrorHandler(int numOptions)
        {
            Boolean answer = false;
            int option = 0;

            do
            {
                do
                {

                    try
                    {
                        option = int.Parse(Console.ReadLine());
                        answer = true;
                    }
                    catch (Exception)
                    {
                        Console.Write("ENTER A VALID OPTION PLEASE:  ");
                        answer = false;
                    }
                } while (answer == false);

                if (option < 1 || option > numOptions)
                {
                    Console.Write("ENTER A VAID OPTION PLEASE:  ");
                }
                else { }
            } while (option < 1 || option > numOptions);

            return option;
        }
    }
}
