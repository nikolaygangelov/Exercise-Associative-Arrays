

namespace _3._Orders
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Linq;
    class Orders
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();
            double totalPrice = 0;
            
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] inputParameters = input.Split();
                string name = inputParameters[0];
                double price = double.Parse(inputParameters[1]);
                double quantity = double.Parse(inputParameters[2]);

                if (!products.ContainsKey(name))
                {
                    products[name] = new List<double>();
                    products[name].Add(price);
                    products[name].Add(quantity);
                }
                else
                {
                    products[name][1] += quantity;
                    
                    if (products[name][0] != price)
                    {
                        products[name][0] = price;
                    }

                }
            }

            foreach (var kvp in products)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value[0] * kvp.Value[1]:f2}");
            }
        }
    }
}
