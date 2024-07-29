using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Pattern
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("Using For Loop");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Using Do While Loop");
            int x = 1, y = 1;
            do
            {
                do
                {
                    Console.Write("* ");
                    x++;
                } while (x <= y);
                Console.WriteLine();
                y++;
            } while (y <= 5);
        }
    }
}
    