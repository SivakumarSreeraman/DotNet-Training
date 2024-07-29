using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Switch
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Enter a choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You choose 1");
                    break;
                case 2:
                    Console.WriteLine("You choose 2");
                    break;
                default:
                    Console.WriteLine("You have given wrong input");
                    break;
            }
         
        }
    }
}
            
           
            