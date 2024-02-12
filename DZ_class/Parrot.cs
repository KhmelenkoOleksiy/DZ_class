using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_class
{
    public class Parrot : IAnimal
    {
        public Parrot(string name, string ownerName, int age)
        {
            Name = name;
            OwnerName = ownerName;
            Age = age;
        }

        public string Name { get; set; } = string.Empty;
        public string OwnerName { get; set; } = string.Empty;
        public int Age { get; set; }

        public Parrot()
        {
        }
        public void SayHello()
        {
            Console.WriteLine("Кеша хороший:)");
        }
    }
}
