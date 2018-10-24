using static System.Console;
using System;
using System.Collections.Generic;

namespace Packt.CS7
{
    public partial class Person:IComparable<Person>
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

        public static Person operator * (Person p1, Person p2)
        {
            return Person.ProCreate(p1, p2);
        }

        public static int Factorial (int number)
        {
            if (number < 0)
            {
                throw new AggregateException($"{nameof(number)} cant be less than zero.");

            }
            return localFactorial(number);

            int localFactorial(int localNumber)
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }

        // event
        public event EventHandler Shout;
        //field

        public int AngerLevel = 3;
        //method
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                //if something is listening
                if(Shout != null)
                {
                    // then raise the event

                    Shout(this, EventArgs.Empty);
                }
            }
        }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
