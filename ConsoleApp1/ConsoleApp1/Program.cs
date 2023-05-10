using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            //// IF-ELSE STATEMENT
            //Console.Write("Input first number: ");
            //int first = int.Parse(Console.ReadLine());

            //Console.Write("Input second number: ");
            //int second = int.Parse(Console.ReadLine());

            //if (first == second)
            //{
            //    Console.WriteLine("These two numbers are equal");
            //}
            //else
            //{
            //    if (first > second)
            //    {
            //        Console.WriteLine("The first number are greater.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The second number are greater");
            //    }
            //}

            ////LOOP AND BRANCHES
            //int sum = 0;
            //for (int i = 1; i <= 20;  i++)
            //{
            //    if (i%3 == 0) //ODD
            //    {
            //        sum = sum + i;
            //    }
            //}
            //Console.WriteLine($"The sum is {sum}");

            //ARRAYS, LIST, and COLLECTION
            var names = new List<string> { "Philip", "Veli", "Ernest", "Melissa"};
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine(names[1]);

            Console.WriteLine();    

            Console.WriteLine("What name do you want to find?");
            var index = names.IndexOf(Console.ReadLine());
            if (index == -1)
            {
                Console.WriteLine("Index not Found");
            }
            else
            {
                Console.WriteLine($"The name of {names[index]} is found on {index}");
            }

        }
    }
}