

namespace _7._Company_users
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] inputParameters = command.Split(" -> ");
                string companyName = inputParameters[0];
                string employeeId = inputParameters[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string>();
                }

                if (companies[companyName].Contains(employeeId))
                {
                    continue;
                }
                companies[companyName].Add(employeeId);
            }

            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
