using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Constructs
{
    class Program
    {
        static void Main(string[] args)
        {
            // description of method: Practicing loop concepts using for, while and do/while loops
            // Inputs: int i and count i 
            // Outputs: each iteration of a loop writes i or count to a line, the iterations are concatinated onto a single lin
            // using formatting we can insert a space between each value
            // Behavior: Each loop prints the number 1-5 separated by a space on a single line
            #region for loop
            Console.WriteLine("numbers 1-5 printed on a single separated by a space line using a for loop");
            for (int i = 1; i < 6; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region while loop
            Console.WriteLine("numbers 1-5 printed on a single line separated by a space using a while loop");
            int count = 1;
            while (count < 6)
            {
                Console.Write("{0} ", count);
                count++;
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region do/while loop
            Console.WriteLine("numbers 1-5 printed on a single line separated by a space using a do/while loop");
            int j = 1;
            do
            {
                Console.Write("{0} ", j);
                j++;
            } while (j < 6);
            Console.WriteLine();
            Console.WriteLine();
            #endregion
        }
    }
}
