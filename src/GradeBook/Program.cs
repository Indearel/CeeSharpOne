using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() {34.1, 25.5, 14.7, 69.3};
            grades.Add(47.2);

            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"Hello, the average grade value is {result:N2}");

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
