using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Animal
    {
        // It means that animal has a name and can speak
        public abstract string Name { set; get; }
        public abstract void speak();

        // Dog derives the animal class
        class Dog : Animal
        {
            public override string Name { set; get; }
            public override void speak()
            {
                Console.WriteLine("Woof!");
            }
        }

        class Cat : Animal
        {
            public override string Name { set; get; }
            public override void speak()
            {
                Console.WriteLine("Meow!");
            }
        }

        static void Main(string[] args)
        {
            // Create Dog object
            var dog = new Dog();
            dog.Name = "Blacky";
            Console.WriteLine(dog.Name);
            dog.speak();

            // Create Cat object
            var cat = new Cat();
            cat.Name = "Oyen";
            Console.WriteLine(cat.Name);
            cat.speak();

            //Console.WriteLine($"The dog is called {dog.Name} and it has {dog.speak()} sounds");
        }
    }
}
