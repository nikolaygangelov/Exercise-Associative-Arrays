

namespace _5._Courses
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Linq;
    class Courses
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputParameters = input.Split(" : ");
                string courseName = inputParameters[0];
                string studentName = inputParameters[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }

                courses[courseName].Add(studentName);
            }

            foreach (var kvp in courses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (string studentName in kvp.Value)
                {
                    Console.WriteLine($"-- {studentName}");
                }

            }

        }
    }
}
