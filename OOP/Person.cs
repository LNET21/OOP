using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Person
    {
        public string Name { get; set; }
    }

    class Employee  : Person
    {
        public int Salary { get; set; }
    }

    class Admin : Employee
    {
        public string Department { get; set; }
    }
}
