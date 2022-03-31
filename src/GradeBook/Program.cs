using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0) 
            {
                Console.WriteLine("Hello " + args[0] + " !");
                Console.WriteLine($"Hello {args[1]} !");
            }
            else {
                Console.WriteLine("There is no Name here");
            }
        }
    }
}
