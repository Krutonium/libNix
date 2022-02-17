using System;
using libNix;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var Nixie = new Nix();
            //Ask the user for a package to search for
            Console.WriteLine("What package do you want to search for?");
            Console.Write(">");
            var package = Console.ReadLine();
            //Search for the package
            var results = Nixie.search(package, 5);
            //Print the results
            foreach (var result in results)
            {   
                Console.WriteLine(result);
            }
            Console.WriteLine("==================================================");
            foreach(var option in Nixie.getOptions(package, 5))
            {
                Console.WriteLine(option.Description);
                Console.WriteLine(option.Name);
                Console.WriteLine(option.DefaultValue);
                Console.WriteLine(option.ExampleValue);
                Console.WriteLine(option.Type);
                Console.WriteLine("==========================");
            }
        }
    }
}