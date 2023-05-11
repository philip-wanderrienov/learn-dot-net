using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a collection of Student
            List<Student> list = new List<Student>();

            // Create an object of student
            var student1 = new Student { Id = 1, Name = "Philip Wanderrienov", Description = "Mahasiswa Pertama", NIM = 123 };
            var student2 = new Student { Id = 2, Name = "Veli Haloho", Description = "Mahasiswa Kedua", NIM = 1234 };
            var student3 = new Student { Id = 3, Name = "Felix Ernest", Description = "Mahasiswa Ketiga", NIM = 12345 };
            var student4 = new Student { Id = 4, Name = "Winny Lie", Description = "Mahasiswa Keempat", NIM = 123456 };

            // Adding every student into the list
            list.Add(student1);
            list.Add(student2);
            list.Add(student3);
            list.Add(student4);

            // Showup the list into the console
            foreach (var index in list) 
            {
                Console.WriteLine($"ID: {index.Id} | Name: {index.Name} | Description: {index.Description} | NIM: {index.NIM}");
            }

            Console.WriteLine();

            string[] capitals = { "Sofia", "Washington", "London", "Paris" };
            foreach (string capital in capitals)
            {
                Console.WriteLine(capital);
            }

            Console.ReadLine();
        }
    }
}
