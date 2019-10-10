using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        // description of method:Uses a series of methods, loops and decision structures to print out the various potential conditional problems 
        // a user could have with a computer, and their corresponding solutions
        // Inputs: condition methods, ints i, j, and k, Yes and No values
        // Outputs: Every example of a conditionl problem and its associated solutions are printed to the terminal
        // Behavior: Using a for loop with two nested loops with the values int i, j, and k respectively 
        // set to run until a value is equal to two, each iteration uses if else statements to determine if the number presented is 0 or 1, 
        // from there the value of yes or no is assigned and is printed to the console window. Using if statements we can take the numbers generated from the 
        // for loops we can build boolean error codes and assign the correct solutions to print if the if statement is true.

        static void Power()
        {
            Console.WriteLine("Check the power cable\n");
        }

        static void Printer()
        {
            Console.WriteLine("Check the printer-computer cable\n");
        }

        static void Software()
        {
            Console.WriteLine("Ensure printer software is installed\n");
        }

        static void Ink()
        {
            Console.WriteLine("Check/replace ink\n");
        }

        static void Jam()
        {
            Console.WriteLine("Check for paper jam\n");
        }

        static void Why()
        {
            Console.WriteLine("Why are you contacting support?\n");
        }
            
        static void Main(string[] args)
        {
            #region 1
            
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++) 
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.WriteLine("----------------Issue(s)-----------------\n");
                        if (i == 0)
                            Console.WriteLine("Printer prints: No\n");
                        else
                            Console.WriteLine("Printer prints: Yes\n");
                        if (j == 0)
                            Console.WriteLine("A red light is flashing: No\n");
                        else
                            Console.WriteLine("A red light is flashing: Yes\n");
                        if (k == 0)
                            Console.WriteLine("Printer is recognized by computer: No\n");
                        else
                            Console.WriteLine("Printer is recognized by computer: Yes\n");
                        Console.WriteLine("---------------Solution(s)---------------\n");
                        if (i == 0 && j == 0 && k == 0)
                        {
                            
                            Power();
                            Printer();
                            Software();
                          
                        }

                        if (i == 0 && j == 0 && k == 1)
                        {
                            Jam();
                        }

                        if (i == 0 && j == 1 && k == 0)
                        {
                            Printer();
                            Software();
                            Ink();
                        }

                        if (i == 0 && j == 1 && k == 1)
                        {
                            Ink();
                            Jam();
                        }

                        if (i == 1 && j == 1 && k == 1)
                        {
                            Ink();
                        }

                        if (i == 1 && j == 1 && k == 0)
                        {
                            Software();
                        }

                        if (i == 1 && j == 0 && k == 0)
                        {
                            Software();
                        }

                        if (i == 1 && j == 0 && k == 1)
                        {
                            Why();
                        }
                                                                                                                                                                                        }
                }
            }
            #endregion

            #region 2
            // description of method:Uses a series of methods, a for loopswitch statements and cases to print out the various potential conditional problems 
            // a user could have with a computer, and their corresponding solutions
            // Inputs: condition methods, ints i initially set to 0, and cases 0-7
            // Outputs: Every example of a conditionl problem and its associated solutions are printed to the terminal
            // Behavior: Using a for loop with the value int i = 0 set to run until i is equal to eight, each iteration uses a switch statement, from here the value of i 
            // during the iteration runs down a list of cases until it reaches the case with the same value as itself. Each case has been coded to provide the errors and thier 
            // solutions for the secified case. Once a case has been completed, a break statement is initiated to restart the loop with i being increased by one.
            
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("---------------Conditions---------------\n");
                        Console.WriteLine("Printer prints: No\n");
                        Console.WriteLine("A red light is flashing: No\n");
                        Console.WriteLine("Printer is recognized by computer: No\n");
                        Console.WriteLine("---------------Solutions----------------");
                        Power();
                        Printer();
                        Software();
                        break;
                    case 1:
                        Console.WriteLine("---------------Conditions---------------\n");
                        Console.WriteLine("Printer prints: No\n");
                        Console.WriteLine("A red light is flashing: No\n");
                        Console.WriteLine("Printer is recognized by computer: Yes\n");
                        Console.WriteLine("---------------Solutions----------------");
                        Jam();
                        break;
                    case 2:
                        Console.WriteLine("---------------Conditions---------------\n");
                        Console.WriteLine("Printer prints: No\n");
                        Console.WriteLine("A red light is flashing: Yes\n");
                        Console.WriteLine("Printer is recognized by computer: No\n");
                        Console.WriteLine("---------------Solutions----------------");
                        Printer();
                        Software();
                        Ink();
                        break;
                    case 3:
                        Console.WriteLine("---------------Conditions---------------\n");
                        Console.WriteLine("Printer prints: No\n");
                        Console.WriteLine("A red light is flashing: Yes\n");
                        Console.WriteLine("Printer is recognized by computer: Yes\n");
                        Console.WriteLine("---------------Solutions----------------");
                        Ink();
                        Jam();
                        break;
                    case 4:
                        Console.WriteLine("---------------Conditions---------------\n");
                        Console.WriteLine("Printer prints: Yes\n");
                        Console.WriteLine("A red light is flashing: No\n");
                        Console.WriteLine("Printer is recognized by computer: No\n");
                        Console.WriteLine("---------------Solutions----------------");
                        Software();
                        break;
                    case 5:
                        Console.WriteLine("---------------Conditions---------------\n");
                        Console.WriteLine("Printer prints: Yes\n");
                        Console.WriteLine("A red light is flashing: No\n");
                        Console.WriteLine("Printer is recognized by computer: Yes\n");
                        Console.WriteLine("---------------Solutions----------------");
                        Why();
                        break;
                    case 6:
                        Console.WriteLine("---------------Conditions---------------\n");
                        Console.WriteLine("Printer prints: Yes\n");
                        Console.WriteLine("A red light is flashing: Yes\n");
                        Console.WriteLine("Printer is recognized by computer: No\n");
                        Console.WriteLine("---------------Solutions----------------");
                        Software();
                        break;
                    case 7:
                        Console.WriteLine("---------------Conditions---------------\n");
                        Console.WriteLine("Printer prints: Yes\n");
                        Console.WriteLine("A red light is flashing: Yes\n");
                        Console.WriteLine("Printer is recognized by computer: Yes\n");
                        Console.WriteLine("---------------Solutions----------------");
                        Ink();
                        break;
                }
            }

            #endregion
        }
    }
}
