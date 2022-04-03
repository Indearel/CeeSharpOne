using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Jussto`s Grade Book");
            book.AddGrade(23.1);
            book.AddGrade(79.9);
            book.AddGrade(50.4);

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"Hello, the average grade value is {stats.Average}");
        }
    }
}
