using System;

namespace AdventOfCode2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Day1 day1 = new Day1();
            int day1Part1Result = day1.RunPart1();
            int day1Part2Result = day1.RunPart2();

            Console.WriteLine("Day 1 Part 1 result is: " + day1Part1Result);
            Console.WriteLine("Day 1 Part 2 result is: " + day1Part2Result);
            Console.ReadKey();
        }
    }
}
