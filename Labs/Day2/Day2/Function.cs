using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Function
    {
      /*  public static int sum(int a, int b) 
        { 
            return a + b;
        }  */

         static int FindMax(int a, int b, int c) 
        {
            int max = a;
            if(b>max)
            {
                max = b;
            }
            if(c>max)
            {
                max = c;
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int c = int.Parse(Console.ReadLine());

            int maxValue = FindMax(a, b, c);
            Console.WriteLine("The Maxvalue is : " + maxValue);
            // Console.WriteLine("Sum is : "+sum(5, 10));
        }
    }
}
