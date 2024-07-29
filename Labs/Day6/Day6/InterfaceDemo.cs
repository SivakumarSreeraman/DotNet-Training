using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    interface Idemo
    {
        public void Print();
    }
    class Example : Idemo
    {
        public void Print() {
            Console.WriteLine("Hi");
        }
    }


    internal class InterfaceDemo
    {
        public static void Main5()
        {
            Example e = new Example();
            e.Print();
        }
    }
}
