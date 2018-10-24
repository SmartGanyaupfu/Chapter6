using System;
using static System.Console;
using Packt.CS7;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Smart!");
            var smart = new Person { Name = "Smart" };
            var mobbby = new Person { Name = "Mobby" };
            var baShane = new Person { Name = "baShane" };

            var shane = smart.ProCreateWith(mobbby);

            WriteLine($"{smart.Name} has {smart.Children.Count} children");
            WriteLine($"{mobbby.Name} has {mobbby.Children.Count} children");
            WriteLine($"{baShane.Name} has {baShane.Children.Count} children");
            WriteLine($"{smart.Name}' is named {smart.Children[0].Name }");


        }
    }
}
