using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Person
    {
        private string Name;            //properties
        private int Age;                //properties
        private DateTime CreatedAt;     //properties

        public Person() {
            CreatedAt = DateTime.Now;
        }

        public DateTime GetCreationDate()
        {
            return CreatedAt;
        }

        public void setName(string Name)
        {
            this.Name = Name;
        }

        public string getName()
        {
            return this.Name;
        }

        public void setAge(int Age)
        {
            if (Age > 0 && Age < 100)
            {
                this.Age = Age;
            }
            else
            {
                throw new Exception("Invalid Age");
            }
        }

        public int getAge() { 
            return this.Age;
        }

        public void DisplayPersonDetails()      //methods
        {
            Console.WriteLine($"name = {Name}, Age = {Age}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.setName("Philip");
            p.setAge(20);
            Console.WriteLine($"Create at :{p.GetCreationDate()}");
            p.DisplayPersonDetails();
            Console.ReadLine();
        }
    }
}
