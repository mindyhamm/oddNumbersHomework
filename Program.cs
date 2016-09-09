using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbersHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the odd numbers from 1 to 99, one number per line, inclusive.
            //start at 1, state condition lt or =99, add 2 after each loop
            int counter;
            for (counter = 1; counter <= 99; counter += 2)
            {
                System.Console.WriteLine(counter);

            }
        }
    }
}