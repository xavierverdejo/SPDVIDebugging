using System;

namespace SPDVIDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.FirstName = "Timothy";
            p.LastName = "Corey";

            Console.WriteLine(p.FunkyNameBuilder());
            Console.ReadLine();
        }
    }
}
