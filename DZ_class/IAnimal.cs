using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_class
{
    public interface IAnimal
    {
        string Name { get; set; }
        string OwnerName { get; set; }

        void SayHello()
        {
            Console.WriteLine("I am default implementation");
        }
    }
}
