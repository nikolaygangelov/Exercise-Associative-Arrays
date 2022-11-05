
namespace _2._A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(command))
                {
                    resources[command] = 0;
                }
                resources[command] += quantity;
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
