using System;

namespace FirstApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //int num1, num2;
            //Console.WriteLine("Enter first Number : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second Number : ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num1 + num2);

            Console.WriteLine("Program to print whether a given input number is Odd or Even");
            int num1;
            Console.WriteLine("Enter a number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
      
            if(num1 % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}