using System;
namespace ClassLibrary1
{
    public class Class1
    {
        static void Main(string[] args)
        {
            //int age = 20;
            //string b = age.ToString();
            //Console.WriteLine(b.GetType());

            //string text = "123";
            //int number = Convert.ToInt32(text);
            //Console.WriteLine(number);

            //int value = 10;
            //object obj = value; // Boxing
            //int newValue = (int)obj; // Unboxing
            //Console.WriteLine(newValue);

            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
        }
    }
}
