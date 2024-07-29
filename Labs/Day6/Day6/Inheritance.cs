using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Inheritance
    {
        class A
        {
            public A()
            {
                Console.WriteLine("A");
            }
        }
        class B : A
        {
            public B()
            {
                Console.WriteLine("B");
            }
        }

        class C : B
        {
            public C()
            {
                Console.WriteLine("C");
            }
        }
            
       static void Main3(string[] args)
        {
            C c=new C(); 
        }
        
    }
}
