using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Person : IPerson
    {
        public string Name { get; set; }

        public void Do()
        {
            Console.WriteLine("Doing");
        }
    }

    class Employee  : Person
    {
        public int Salary { get; set; }
    }

    class Admin : Employee
    {
        public string Department { get; set; }
    }

    class Instructor : IPerson
    {
        public string Name { get; set; }

        public void Do()
        {
            Console.WriteLine("Instrustor");
        }
    }

    class Dog : IPerson
    {
        public string Name { get; set; }

        public void Do()
        {
            Console.WriteLine("Dog");
        }
    }
}
