using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inheritance.Employee;

namespace Inheritance
{
    public class Employee
    {
        //BASE CLASS
        public int id;
        public string name;

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Employee()
        {
            
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"Id: {id} name: {name}");
        }

        public class Programmer : Employee       //Programmer class is now inherit with Employee class
        {
            //DERIVE CLASS
            public Programmer(int id, string name) : base(id, name)
            {
            }

            public void getCoffee()
            {
                Console.WriteLine("Getting Coffee!");
            }
        }
        public class Manager : Employee         //Manager class is now inherit with Employee class
        {
            //DERIVE CLASS
            public Manager(int id, string name) : base(id, name)
            {
            }

            public void AssignTask()
            {
                Console.WriteLine("Assigning Task!");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "Philip");
            emp.DisplayEmployee();
            Programmer prg = new Programmer(2, "Felix");
            prg.DisplayEmployee();
            prg.getCoffee();
            Manager mgr = new Manager(3, "Veli");
            mgr.DisplayEmployee();
            mgr.AssignTask();
        }
    }
}
