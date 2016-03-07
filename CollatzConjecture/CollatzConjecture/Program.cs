using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    class Program
    {
        static int GetIntegerFromUser(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    string input = Console.ReadLine();
                    int x = int.Parse(input);
                    return x;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter an integer.");
                }
            }
        }

        static void Main(string[] args)
        {
            int startingNumber = GetIntegerFromUser("Please enter a number.");
            int LoopCycle = 0;
            int largeCycle = 0;
            int x = startingNumber;
            int largest = startingNumber;
            while (x != 1)
            {
                if (x % 2 == 0)
                {
                    x /= 2;
                    if (x > largest)
                    {
                        largest = x;
                        LoopCycle = largeCycle;
                    }
                    LoopCycle += 1;
                }
                else
                {
                    x *= 3;

                    x += 1;
                    if (x > largest)
                    {
                        largest = x;
                        largeCycle = LoopCycle;
                    }
                    LoopCycle += 1;
                }
            }
            Console.WriteLine("It takes {0} steps to reach 1 from {1}.", LoopCycle, startingNumber);
            Console.WriteLine("The value reaches its peak of {0} at step {1}.", largest, largeCycle); // Max and Cycle
            Console.ReadKey();
        }
    }
}