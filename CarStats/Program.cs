using System;
using Spectre.Console;
using Bogus;
using System.Reflection.Metadata.Ecma335;

namespace CarStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(Convert.ToInt32(args[0]));
            string[] carBrands = new string[] { "BMW", "Audi", "Mercedes", "VW", "Ford", "Toyota", "Honda", "Nissan", "Hyundai", "Kia" };
            int carOrder = 0;
            Faker faker = new Faker<Order>()
                .StrictMode(true)
                .RuleFor(o => o.CarBrand, f => carBrands[carOrder++ % carBrands.Length])
                .RuleFor(o => o.Item, f => f.Random.Number(1, 20))
                .RuleFor(o => o.Quantity, f => f.Random.Number(1, 20));
            
            BarChart bc = new BarChart();
            bc.AddItem("BMW", faker.Random.Number(1, 20));
        }
        public string Manufacturer()
        {
            return GetRandomArrayItem("manufacturer");
        }
    }
}
