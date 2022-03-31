using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] {34.1, 25.5, 14.7, 69.3};
            var grades = new List<double>() {34.1, 25.5, 14.7, 69.3};
            grades.Add(47.2);
            // var averageScore = grades / 5;

            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }
            Console.WriteLine(result);

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
