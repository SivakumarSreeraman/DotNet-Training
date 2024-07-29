using System;

namespace Pattern_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,i,j;
            for (i = 1; i <=5; i++)
            {
                for (j = 5; j >=i; j--)
                {
                    
                    Console.Write("* ");
                   
                }
                
                Console.WriteLine();
              
            }
            for (a = 1; a <= 5; a++)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}