

namespace _4._SoftUni_Parking
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> plateNumbers = new Dictionary<string, string>(); 

            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();

                string[] inputParameters = command.Split();
                string commandType = inputParameters[0];
                string username = inputParameters[1];
                
                if (commandType == "register")
                {
                    
                    string licensePlateNumber = inputParameters[2];

                    if (!plateNumbers.ContainsKey(username))
                    {
                        plateNumbers.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    } 
                }
                else
                {
                    if (!plateNumbers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        plateNumbers.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var kvp in plateNumbers)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
