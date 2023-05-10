using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a myCar object
            Car myCar = new Car();

            myCar.horn();

            Console.WriteLine($"My car brand is {myCar.brand} and the model is {myCar.modelName}.");
        }
    }
}
