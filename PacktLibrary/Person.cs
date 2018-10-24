using static System.Console;
using System;
using System.Collections.Generic;

namespace Packt.CS7
{
    public partial class Person
    {
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born {DateOfBirth:dddd, d MMMM yyyy}");
        }

        public static  Person ProCreate( Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"baby of {p1.Name} and {p2.Name}"
            };

            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
    
        }

        public Person ProCreateWith(Person partner)
        {
            return ProCreate(this, partner);
        }
    }
}
