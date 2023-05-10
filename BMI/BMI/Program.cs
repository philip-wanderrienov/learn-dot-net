using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI   //Body Mass Index
{
    class Person
    {
        // PROPERTIES
        //public string Name { get; set; }
        //public int Age { get; set; }
        //public string Gender { get; set; }
        //public int Height { get; set; }
        //public int Weight { get; set; }

        public string Name;
        public int Age;
        public string Gender;
        public int Height;
        public int Weight;

        // CONSTRUCTIOR
        public Person (string name, int age, string gender, int height, int weight) 
        { 
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Height = height;
            this.Weight = weight;
        }

        // METHOD
        public int CalculateBMI()
        {
            // The input weight is considered as a KG
            // The input height is consideres as a CM

            // Changing cm to meter
            int heightInMeters = Height / 100;
            return Weight / (heightInMeters^2);
        }

        static void Main(string[] args)
        {
            Console.Write("Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Your Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Your Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Your Height in CM: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Your Weight in KG: ");
            int weight = int.Parse(Console.ReadLine());

            var person = new Person(name,age,gender,height,weight);

            Console.WriteLine();
            Console.WriteLine("THE RESULT");
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Gender: {person.Gender}");
            Console.WriteLine($"Your Body Mass Index (BMI): {person.CalculateBMI()}");
        }
    }
}
