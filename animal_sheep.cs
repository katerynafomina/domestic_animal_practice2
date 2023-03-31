using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domesticAnimal
{
    public class Sheep : Animal
    {
        public Sheep()
            : base()
        {
            Type = "вівця";
            Profit = "шерсть";
        }
        public Sheep(double age, double weight, double priceOfMeat)
            : base(age, weight, priceOfMeat)
        {
            Type = "вівця";
            Profit = "шерсть";
        }
        public void HotSummer()
        {
            if (Age >= 5)
            {
                Productivity *= 0.7;
                Productivity = Math.Round(Productivity, 3);
            }
        }
        public override Sheep Dialog()
        {
            Console.WriteLine("\nВведіть дані для нової вівці:");

            Console.Write("Вiк: ");
            double age = double.Parse(Console.ReadLine());
            Console.Write("Вага: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Цiна м'яса: ");
            double priceOfMeat = double.Parse(Console.ReadLine());
            Console.WriteLine();

            return new Sheep(age, weight, priceOfMeat);
        }
        public override void ReadFrom()
        {
            Console.Write("Вiк: ");
            Age = double.Parse(Console.ReadLine());
            Console.Write("Вага: ");
            Weight = double.Parse(Console.ReadLine());
            Console.Write("Цiна м'яса: ");
            PriceOfMeat = double.Parse(Console.ReadLine());
            Console.WriteLine();
            if (Age >= 5)
            {
                Productivity = Math.Round(this.Age * this.Weight / 20, 3);
            }
            else
            {
                Productivity = 0.0;
            }
        }
    }
}
