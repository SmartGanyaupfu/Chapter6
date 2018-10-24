using System;
using static System.Console;
using Packt.CS7;

namespace PeopleApp
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Smart!");
            var smart = new Person { Name = "Smart" };
            var mobbby = new Person { Name = "Mobby" };
            var baShane = new Person { Name = "baShane" };

            var shane = smart.ProCreateWith(mobbby);
            var baby2 = Person.ProCreate(baShane, mobbby);

            var baby3 = baShane * mobbby;


            WriteLine($"{smart.Name} has {smart.Children.Count} children");
            WriteLine($"{mobbby.Name} has {mobbby.Children.Count} children");
            WriteLine($"{baShane.Name} has {baShane.Children.Count} children");
            WriteLine($"{smart.Name}' is named {smart.Children[0].Name }");

            WriteLine($"5! is {Person.Factorial(0)}");

            smart.Shout += Smart_Shout;
            smart.Poke();
            smart.Poke();
            smart.Poke();
            smart.Poke();

            Person[] people =
            {
                new Person {Name ="Munashe"},
                new Person {Name="Chipo"},
                new Person{Name = "Simba"}
            };

            WriteLine($"initial lis of people :");

            foreach (var person in people)
            {
                WriteLine($"{person.Name}");

            }

            WriteLine($"Use Person's Icomparable Implementation to sort");
            Array.Sort(people);

            foreach (var person in people)
            {
                WriteLine($"{person.Name}");

            }

            WriteLine($"use PersonICOmparer's IComparer implementation to sort:");

            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");

            }





        }

        private static void Smart_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
        }
    }
}
