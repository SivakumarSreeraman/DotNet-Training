using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Loops
    {
        static void Main3(string[] args)
        {
            //for loop
            Console.WriteLine("For Loop");
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(index + " ");
            }
            Console.WriteLine("\n"+"======================");

            // do while loop
            Console.WriteLine("Do while Loop");
            int doindex = 0;
            do
            {
                Console.WriteLine(doindex+" ");
                doindex++;
            } while (doindex < 10);
            Console.WriteLine("\n"+"======================");

            // while loop
            Console.WriteLine("While Loop");
            int whileindex = 0;
            while (whileindex < 10) 
            {
                Console.WriteLine(whileindex+" ");
                whileindex++;
            }
        }
    }
}
