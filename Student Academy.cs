
namespace _6._Student_Academy
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                }

                students[studentName].Add(grade);
            }


            foreach (var kvp in students.Where(x => x.Value.Sum() / x.Value.Count >= 4.50))
            {
                Console.WriteLine($"{kvp.Key} –> {kvp.Value.Sum() / kvp.Value.Count:f2}");
            }
        }
    }
}
