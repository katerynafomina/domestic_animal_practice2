using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domesticAnimal
{
    public class Cow : Animal
    {
        private double fatness;
        public Cow()
            : base()
        {
            Type = "корова";
            Profit = "молоко";
            fatness = 0.0;
        }
        public Cow(double age, double weight, double priceOfMeat, double fatness)
            : base(age, weight, priceOfMeat)
        {
            Type = "корова";
            Profit = "молоко";
            this.fatness = fatness;
        }
        public double Fatness
        {
            get
            {
                if (Age >= 2)
                {
                    return fatness;
                }
                else
                {
                    return 0.0;
                }
            }
            set { fatness = value; }
        }
        public override string ToString()
        {
            return base.ToString() + $", жирність молока: {Fatness}";
        }
        public enum Feed
        {
            Oat,
            Corn,
            FeedGrassFed
        }
        public void FeedWith(Feed f)
        {
            if (f == Feed.Oat)
            {
                if (Age >= 2)
                {
                    Productivity += Productivity * 0.02;
                    Productivity = Math.Round(Productivity, 3);
                    fatness += fatness * 0.01;
                    fatness = Math.Round(fatness, 3);
                }
            }
            if (f == Feed.Corn)
            {
                if (Age >= 2)
                {
                    Productivity += Productivity * 0.05;
                    Productivity = Math.Round(Productivity, 3);
                    fatness += fatness * 0.05;
                    fatness = Math.Round(fatness, 3);
                }
            }
            if (f == Feed.FeedGrassFed)
            {
                if (Age >= 2)
                {
                    Productivity += Productivity * 0.08;
                    Productivity = Math.Round(Productivity, 3);
                    fatness += fatness * 0.03;
                    fatness = Math.Round(fatness, 3);
                }
            }
        }
        public override Cow Dialog()
        {
            Console.WriteLine("\nВведіть дані для нової корови:");

            Console.Write("Вiк: ");
            double age = double.Parse(Console.ReadLine());
            Console.Write("Вага: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Цiна м'яса: ");
            double priceOfMeat = double.Parse(Console.ReadLine());
            Console.Write("Жирність молока: ");
            double fatness = double.Parse(Console.ReadLine());
            Console.WriteLine();

            return new Cow(age, weight, priceOfMeat, fatness);
        }
        public override void ReadFrom()
        {
            Console.Write("Вiк: ");
            Age = double.Parse(Console.ReadLine());
            Console.Write("Вага: ");
            Weight = double.Parse(Console.ReadLine());
            Console.Write("Цiна м'яса: ");
            PriceOfMeat = double.Parse(Console.ReadLine());
            Console.Write("Жирність молока: ");
            fatness = double.Parse(Console.ReadLine());
            Console.WriteLine();
            if (Age >= 2)
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

