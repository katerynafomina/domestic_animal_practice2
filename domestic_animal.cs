using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domesticAnimal
{
    public class Animal
    {
        private string type;
        private double age;
        private double weight;
        private double priceOfMeat;
        public Animal()
        {
            type = "";
            age = 0.0;
            weight = 0.0;
            priceOfMeat = 0.0;
        }
        public Animal(string type, double age, double weight, double priceOfMeat)
        {
            this.type = type;
            this.age = age;
            this.weight = weight;
            this.priceOfMeat = priceOfMeat;
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
        public double productivity
        {
            get
            {
                if (age >= 2)
                {
                    return this.age * this.weight / 20;
                }
                else
                {
                    return 0.0;
                }
            }
        }
        public double price
        {
            get { return this.weight * this.priceOfMeat; }
        }
        public void addYear(int n)
        {
            Age += n;
            Weight += 0.5 * n;
        }
        public void showProductivity()
        {
            Console.WriteLine(string.Format("\nПродуктивнiсть тварини {0} складає: {1}", type, productivity));
        }
        public Animal dialog()
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
            Console.WriteLine();

            return new Animal(type, age, weight, priceOfMeat);
        }
        public static bool operator >(Animal a, Animal b)
        {
            return a.price > b.price;
        }

        public static bool operator <(Animal a, Animal b)
        {
            return a.price < b.price;
        }

        public static bool operator >=(Animal a, Animal b)
        {
            return a.price >= b.price;
        }

        public static bool operator <=(Animal a, Animal b)
        {
            return a.price <= b.price;
        }
        public void readFrom()
        {
            Console.Write("Вид тварини: ");
            type = Console.ReadLine();
            Console.Write("Вiк: ");
            age = uint.Parse(Console.ReadLine());
            Console.Write("Вага: ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Цiна м'яса: ");
            priceOfMeat = double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return string.Format("Назва виду: {0}, вiк: {1}, вага: {2} кг, цiна м'яса: {3} грн/кг, продуктивнiсть: {4}, цiна: {5} грн.", type, age, weight, priceOfMeat, productivity, price);
        }

    }

}