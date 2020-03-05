using System;

namespace Codykyl
{
    class Program
    {
        static void Main(string[] args)
        {
            string first, last;
            Console.WriteLine("enter your first nname");
            first=Console.ReadLine();
            Console.WriteLine("enter your last name");
            last = Console.ReadLine();
            Console.WriteLine("hello {0} {1}", first, last );
            Console.ReadLine();
        }
    }
}
