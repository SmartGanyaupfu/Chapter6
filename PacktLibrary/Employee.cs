using static System.Console;
using System.Collections.Generic;
using System.Text;
using System;

namespace Packt.CS7
{
    public class Employee:Person
    {
        public string Empcode { get; set; }
        public DateTime Hiredate { get; set; }

        public new void WriteToConsole()
        {
            WriteLine($"{Name} was born {DateOfBirth:dddd, d MMMM yyyy} and hired {Hiredate:dd/MM/yy}");
        }

        public override string ToString()
        {
            return $"{Name} code is {Empcode}";
        }
    }
}
