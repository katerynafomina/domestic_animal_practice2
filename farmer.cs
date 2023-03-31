using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domesticAnimal
{
    public class Farmer
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Farmer(string name)
        {
            this.name = name;
        }
        public void FarmerWithAnimal(object sender, EventArgs e)
        {
            Animal animal = sender as Animal;
            Console.WriteLine("Фермер {0} повідомляє, що тварина {1} досягла продуктивного віку! ", name, animal.Type);
        }
    }
}