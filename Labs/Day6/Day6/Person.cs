using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Person
    {
        public string Name { get; set; }
        // Constructor
        public Person(string name)
        {
            Name = name;
        }
        // Destructor
        ~Person() 
        {
            Name = string.Empty;
        }
        //Override ToString method
        public override string ToString() 
        {
            return $"Hello! My name is {Name}";
        }
    }

    class Program
    {
        static void Main2()
        {
            Person[] people = new Person[3];
            for(int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();
                people[i] = new Person(name);
            }
            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
