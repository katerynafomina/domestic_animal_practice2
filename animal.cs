using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domesticAnimal
{
    public class Animal : IComparable<Animal>, ICloneable
    {
        private string type;
        private double age;
        private double weight;
        private double priceOfMeat;
        private double productivity;
        private string profit;
        public delegate void AnimalDelegate();
        public event AnimalDelegate ReachProductivityAge;

        public Animal()
        {
            type = "";
            age = 0.0;
            weight = 0.0;
            priceOfMeat = 0.0;
            productivity = 0.0;
            profit = "нічого";
        }
        public Animal(string type, double age, double weight, double priceOfMeat, string profit)
        {
            this.type = type;
            this.age = age;
            this.weight = weight;
            this.priceOfMeat = priceOfMeat;
            this.profit = profit;
            if (age >= 2)
            {
                productivity = Math.Round(this.age * this.weight / 20, 3);
            }
            else
            {
                productivity = 0.0;
            }
        }
        public Animal(double age, double weight, double priceOfMeat)
        {
            type = "";
            this.age = age;
            this.weight = weight;
            this.priceOfMeat = priceOfMeat;
            profit = "";
            if (age >= 2)
            {
                productivity = Math.Round(this.age * this.weight / 20, 3);
            }
            else
            {
                productivity = 0.0;
            }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double PriceOfMeat
        {
            get { return priceOfMeat; }
            set { priceOfMeat = value; }
        }
        public string Profit
        {
            get
            {
                if (age >= 2)
                {
                    return profit;
                }
                else
                {
                    return "нічого";
                }
            }
            set { profit = value; }
        }
        public double Productivity
        {
            get { return productivity; }
            set { productivity = value; }
        }
        public double Price
        {
            get { return Math.Round(this.weight * this.priceOfMeat); }
        }
        public void AddYear(int n)
        {
            Age += n;
            Weight += 0.5 * n;
            if (age >= 2)
            {
                productivity = Math.Round(this.age * this.weight / 20, 3);
            }
        }
        public void ShowProductivity()
        {
            Console.WriteLine(string.Format("\nПродуктивнiсть тварини {0} складає: {1}", type, productivity));
        }
        public virtual Animal Dialog()
        {
            Console.WriteLine("\nВведіть дані для нової тварини:");

            Console.Write("Вид тварини: ");
            string type = Console.ReadLine();
            Console.Write("Вiк: ");
            double age = double.Parse(Console.ReadLine());
            Console.Write("Вага: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Цiна м'яса: ");
            double priceOfMeat = double.Parse(Console.ReadLine());
            Console.Write("Прибуток, який приносить тварина: ");
            string profit = Console.ReadLine();
            Console.WriteLine();

            return new Animal(type, age, weight, priceOfMeat, profit);
        }
        public object Clone()
        {
            return new Animal
            {
                type = this.type,
                age = this.age,
                weight = this.weight,
                priceOfMeat = this.priceOfMeat,
                productivity = this.productivity,
                profit = this.profit
            };
        }
        public void reachProductivity()
        {
            if (productivity != 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Тварина {type} досягла продуктивного віку");
                Console.ResetColor();
                if (ReachProductivityAge != null)
                {
                    ReachProductivityAge();
                }
            }
        }
        public int CompareTo(Animal other)
        {
            if (other == null)
                return 1;
            return Price.CompareTo(other.Price);
        }
        public static bool operator >(Animal a, Animal b)
        {
            return a.Price > b.Price;
        }

        public static bool operator <(Animal a, Animal b)
        {
            return a.Price < b.Price;
        }

        public static bool operator >=(Animal a, Animal b)
        {
            return a.Price >= b.Price;
        }

        public static bool operator <=(Animal a, Animal b)
        {
            return a.Price <= b.Price;
        }
        public virtual void ReadFrom()
        {
            Console.Write("Вид тварини: ");
            type = Console.ReadLine();
            Console.Write("Вiк: ");
            age = double.Parse(Console.ReadLine());
            Console.Write("Вага: ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Цiна м'яса: ");
            priceOfMeat = double.Parse(Console.ReadLine());
            Console.Write("Прибуток, який приносить тварина: ");
            profit = Console.ReadLine();
            Console.WriteLine();
            if (age >= 2)
            {
                productivity = Math.Round(this.age * this.weight / 20, 3);
            }
            else
            {
                productivity = 0.0;
            }
        }
        public override string ToString()
        {
            return string.Format("Назва виду: {0}, вiк: {1}, вага: {2} кг, цiна м'яса: {3} грн/кг, продуктивнiсть: {4}, цiна: {5} грн., прибуток: {6}", type, age, weight, priceOfMeat, productivity, Price, Profit);
        }
    }
}