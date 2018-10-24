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

            var t = new Thing();
            t.Data = 42;
            WriteLine($"Thing: {t.Process("42")}");


            var gt = new GenericThing<int>();
            gt.Data = 42;
            WriteLine($"Thing: {gt.Process("42")}");

            string number1 = "4";
            WriteLine($"{number1} sqaured is {Squarer.Sqaure(number1)}");
            byte number2 = 10;
            WriteLine($"{number2} sqaured is {Squarer.Sqaure<byte>(number2)}");

            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
            var dv3 = dv1 + dv2;

            WriteLine($"({dv1.X},{dv1.Y}) + ({dv2.X},{dv2.Y}) = ({dv3.X}, {dv3.Y})");

            WriteLine(dv1.X);


        }

        private static void Smart_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
        }
    }
}
