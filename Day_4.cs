using System;
using System.Linq;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students : ");
            int num = int.Parse(Console.ReadLine());
            string[] names = new string[num];
            int[] marks = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the name of student " + (i + 1) + " : ");
                names[i] = Console.ReadLine();
                Console.WriteLine("Enter the marks of student " + (i + 1) + " : ");
                marks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Names in Uppercase:");
            foreach (string name in names)
            {
                Console.WriteLine(name.ToUpper());
            }
            Console.WriteLine("Names in Lowercase:");
            foreach (string name in names)
            {
                Console.WriteLine(name.ToLower());
            }
            Console.WriteLine("Names and name length:");
            foreach (string name in names)
            {
                Console.WriteLine(name + " : " + name.Length);
            }
            Console.WriteLine("Enter the name to search: ");
            string searchName = Console.ReadLine();
            int index = Array.IndexOf(names, searchName);
            Console.WriteLine(names[index] + " secures " + marks[index]);
            Console.WriteLine("Highest mark secured by");
            int inmaxMark = Array.IndexOf(marks, marks.Max());
            Console.WriteLine(names[inmaxMark] + " secures " + marks[inmaxMark]);
            Console.WriteLine("Names in ascending order:");
            Array.Sort(names);
            foreach (string name in names)
            {
                Console.Write(name);
            }
            Console.WriteLine("\nNames in descending order:");
            Array.Reverse(names);
            foreach (string name in names)
            {
                Console.Write(name);
            }
            Console.WriteLine("Vowel names");
            foreach (string name in names)
            {
                if (name.StartsWith("A", StringComparison.OrdinalIgnoreCase) ||
                    name.StartsWith("E", StringComparison.OrdinalIgnoreCase) ||
                    name.StartsWith("I", StringComparison.OrdinalIgnoreCase) ||
                    name.StartsWith("O", StringComparison.OrdinalIgnoreCase) ||
                    name.StartsWith("U", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(name);
                }
            }
        }
        
    }
}
