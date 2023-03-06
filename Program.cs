using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domesticAnimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal horse = new Animal();
            horse.readFrom();
            Console.WriteLine(horse);

            Animal cow = new Animal("корова", 3, 23, 100);
            Console.WriteLine(cow);
            cow.showProductivity();
            Animal sheep = new Animal("вiвця", 0.5, 9, 120);
            Console.WriteLine(sheep);
            sheep.addYear(1);
            Console.WriteLine(sheep);
            Console.WriteLine($"\nЧи бiльша корова за вiвцю за загальною цiною? {cow > sheep}");
            Animal pig = new Animal("свиня", 8, 13, 95);
            Animal chicken = new Animal("курка", 7, 1.7, 105);
            Animal rabbit = new Animal("кролик", 0.9, 3, 125);
            List<Animal> farm = new() { cow, sheep, pig, chicken, rabbit };
            int n = farm.Count;


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(farm[i]);
            }

            double maxWeight = farm[0].Weight;
            for (int i = 0; i < n; i++)
            {
                if (farm[i].Weight > maxWeight)
                {
                    maxWeight = farm[i].Weight;
                }
            }
            Console.WriteLine($"\nНайбiльша вага: {maxWeight}");

            double maxProductivity = farm[0].productivity;
            for (int i = 0; i < n; i++)
            {
                if (farm[i].productivity > maxProductivity)
                {
                    maxProductivity = farm[i].productivity;
                }
            }
            Console.WriteLine($"\nНайбiльша продуктивнiсть: {maxProductivity}");

            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                if (farm[i].Age >= 2)
                {
                    counter++;
                }
            }
            if (counter == n)
            {
                Console.WriteLine("\nВсi тварини досягли продуктивного вiку");
            }
            else
            {
                Console.WriteLine($"\nТiльки {counter} з {n} тварин досягли продуктивного вiку");
            }

            for (int i = 0; i < n; i++)
            {
                farm[i].addYear(1);
            }
            Console.WriteLine("\n\nПройшов 1 рiк");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(farm[i]);

            }

            for (int i = 0; i < n; i++)
            {
                farm[i].addYear(2);
            }
            Console.WriteLine("\n\nПройшло 2 роки");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(farm[i]);

            }
            Console.WriteLine("\n\n");
            farm.Sort((x, y) => x.productivity.CompareTo(y.productivity));
            Console.WriteLine($"3 найпродуктивнiшi тварини: {farm[n - 1].Type}, {farm[n - 2].Type}, {farm[n - 3].Type}");

            List<Animal> oldAnimal = new();
            for (int i = 0; i < n; i++)
            {
                if (farm[i].Age >= 10)
                {
                    oldAnimal.Add(farm[i]);
                }
            }
            Console.WriteLine("\n\nТварини старшi 10 рокiв:");
            for (int i = 0; i < oldAnimal.Count; i++)
            {
                Console.WriteLine(oldAnimal[i]);

            }
            Animal noName = new Animal();
            noName = noName.dialog();
            farm.Add(noName);
            for(int i = 0; i < farm.Count; i++)
            {
                Console.WriteLine(farm[i]);

            }
            Console.WriteLine("\n\n");

        }
    }
}