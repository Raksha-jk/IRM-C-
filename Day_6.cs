using System;
namespace Program
{
    public class Animal
    {
        public virtual void MakeSound() // Virtual method
        {
            Console.WriteLine("Animal makes sound");
        }
    }
    public class Dog : Animal
    {
        public override void MakeSound() // Override method
        {
            Console.WriteLine("Dog barks");
        }
    }
    public class Cat: Animal
    {
        public override void MakeSound() // Override method
        {
            Console.WriteLine("Cat meows");
        }
    }
    class Program
    {
        static int CalculateArea(int length, int width)
        {
            return length * width;
        }
        static int CalculateArea(int radius)
        {
            return (int)(Math.PI * radius * radius);
        }
        static void SwapNumbers(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static void Divide(int divident, int divisor, out int quotient, out int remainder)
        {
            quotient = divident / divisor;
            remainder = divident % divisor;
        }
        static int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }
        static int Fib(int n)
        {
            if (n <= 1)
                return n;
            return Fib(n - 1) + Fib(n - 2);
        }
        static int SumofDigits(int n)
        {
            if (n == 0)
                return 0;
            return n % 10 + SumofDigits(n / 10);
        }
        static void Main(string[] args)
        {
            int arearect = CalculateArea(5, 10); // Rectangle
            int areacircle = CalculateArea(7); // Circle
            Console.WriteLine($"Area of rectangle: {arearect}");
            Console.WriteLine($"Area of circle: {areacircle}");
            int a = 5;
            int b = 10;
            //Console.WriteLine(ref a);
            Console.WriteLine($"{a}, {b}"); // Original values
            SwapNumbers(ref a, ref b); // Swapping numbers
            Console.WriteLine($"{a}, {b}"); // Swapped values
            int quotient, remainder;
            Divide(10,5,out quotient, out remainder);
            Console.WriteLine($"Quotient:{quotient} Remainder:{remainder}");
            Console.WriteLine(Factorial(5));//Factorial
            Console.WriteLine(Fib(5));
            Console.WriteLine(SumofDigits(543));
            Dog dog = new Dog();
            Cat cat = new Cat();
            Animal animal = new Animal();
            Console.WriteLine("Dog sound:");
            dog.MakeSound(); // Calls Dog's MakeSound
            Console.WriteLine("Cat sound: ");
            cat.MakeSound(); // Calls Cat's MakeSound
            Console.WriteLine("Animal sound: ");
            animal.MakeSound(); // Calls Animal's MakeSound
        }
    }
}