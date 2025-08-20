using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS2.Classes
{

    // Abstract class
     abstract class Animal
    {
        // Abstract method (must be implemented by derived class)
        public abstract void MakeSound();
        //public virtual void MakeSound()
        //{
        //    Console.WriteLine("Hello");
        //}

        // Normal method (optional to override)
        public void Eat()
        {
            Console.WriteLine("This animal eats food.");
        }
    }
    // Derived class
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }
    // Derived class
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }

}
