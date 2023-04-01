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
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Animal animal1 = new Animal("корова", 1, 23, 100, "молоко");
            Animal animal2 = (Animal)animal1.Clone();
            animal1.AddYear(2);
            animal2.AddYear(2);
            Console.WriteLine(animal1);
            Console.WriteLine(animal2);

            //Animal horse = new Animal();
            //horse.ReadFrom();
            //Console.WriteLine(horse);

            Animal cow = new Animal("корова", 3, 23, 100, "молоко");
            Console.WriteLine(cow);
            cow.ShowProductivity();
            Animal sheep = new Animal("вiвця", 0.5, 9, 120, "шерсть");
            Console.WriteLine(sheep);
            sheep.AddYear(1);
            Console.WriteLine(sheep);
            Console.WriteLine($"\nЧи бiльша корова за вiвцю за загальною цiною? {cow > sheep}");
            Animal pig = new Animal("свиня", 8, 13, 95, "м'ясо");
            Animal chicken = new Animal("курка", 7, 1.7, 105, "яйця");
            Animal rabbit = new Animal("кролик", 0.9, 3, 125, "м'ясо");
            List<Animal> farm = new() { cow, sheep, pig, chicken, rabbit };
            int n = farm.Count;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(farm[i]);
            }

            Console.WriteLine($"\nЦіна курки та свині: {pig + chicken} грн");

            double totalPrice = 0.0;
            for (int i = 0; i < n; i++)
            {
                totalPrice = farm[i] + totalPrice;
            }
            Console.WriteLine($"\nЗагальна ціна всіх тварин в класі: {totalPrice} грн");

            double maxWeight = farm[0].Weight;
            for (int i = 0; i < n; i++)
            {
                if (farm[i].Weight > maxWeight)
                {
                    maxWeight = farm[i].Weight;
                }
            }
            Console.WriteLine($"\nНайбiльша вага: {maxWeight}");

            double maxProductivity = farm[0].Productivity;
            for (int i = 0; i < n; i++)
            {
                if (farm[i].Productivity > maxProductivity)
                {
                    maxProductivity = farm[i].Productivity;
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
                farm[i].AddYear(1);
            }
            Console.WriteLine("\n\nПройшов 1 рiк");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(farm[i]);

            }

            for (int i = 0; i < n; i++)
            {
                farm[i].AddYear(2);
            }
            Console.WriteLine("\n\nПройшло 2 роки");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(farm[i]);
            }

            farm.Sort();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(farm[i]);
            }
            Console.WriteLine($"3 найпродуктивнiшi тварини: {farm[n - 1].Type}, {farm[n - 2].Type}, {farm[n - 3].Type}");

            List<Animal> oldAnimal = new();
            for (int i = 0; i < n; i++)
            {
                if (farm[i].Age >= 10)
                {
                    oldAnimal.Add(farm[i]);
                }
            }
            Console.WriteLine("\n\nTварини старшi 10 рокiв:");
            for (int i = 0; i < oldAnimal.Count; i++)
            {
                Console.WriteLine(oldAnimal[i]);
            }

            //Animal noName = new Animal();
            //noName = noName.Dialog();
            //farm.Add(noName);
            //for (int i = 0; i < farm.Count; i++)
            //{
            //    Console.WriteLine(farm[i]);
            //}
            //Console.WriteLine("\n\n");

            //Farmer farmer1 = new Farmer("");
            //SubscribeToAnimal(farmer1, farm);
            //farm[0].AddYear(1);
            //farm[2].AddYear(2);
            //Console.WriteLine();
        }
        //static void SubscribeToAnimal(Farmer farmer, List<Animal> animals)
        //{
        //    foreach (Animal a in animals)
        //    {
        //        a.FarmerWithAnimalEvent += farmer.FarmerWithAnimal;
        //    }
        //}
    }
}
