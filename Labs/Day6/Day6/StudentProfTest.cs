using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class StudentProfTest
    {


        public class Person
        {
            public int Age { get; private set; }
            public void Greet()
            {
                Console.WriteLine("Hello!");
            }
            public void SetAge(int age)
            {
                Age = age;
            }
        }

        public class Student : Person
        {
            public void Study()
            {
                Console.WriteLine("I'm studying");
            }
            public void ShowAge()
            {
                Console.WriteLine($"My Age is : {Age} years old");
            }
        }

        public class Teacher : Person
        {
            public void Explain()
            {
                Console.WriteLine("I'm explaining");
            }
        }

        static void Main4()
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(21);
            student.Greet();
            student.ShowAge();
            student.Study();

            Teacher teacher = new Teacher();
            teacher.SetAge(35);
            teacher.Greet();
            teacher.Explain();

        }
    }
}

