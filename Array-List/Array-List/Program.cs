using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Lix", "Phil", "Veli" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
        }
    }
}
