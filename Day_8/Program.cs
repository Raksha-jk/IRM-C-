using System;
using OOPS2.Classes;
namespace OOPS2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Manager manager = new Manager();
            //manager.SetDetails("Alice", 75000);
            //manager.SetDepartment("IT");
            //manager.DisplayInfo();
            //Employee employee = new Employee();
            //employee.SetDetails("Bob", 50000);
            ////employee.GetSalary(); // This line will cause a compile-time error because GetSalary is protected
            //List<Employee> employees = new List<Employee>
            //{
            //    new Manager("Alice", 80000, "HR"),
            //    new Developer("Bob", 60000, "C#"),
            //    new Developer("Charlie", 65000, "Java")
            //};

            //foreach (var emp in employees)
            //{
            //    emp.Work();
            //    emp.DisplayInfo();

            //    if (emp is ICoder coder)
            //        coder.Code();
            //}
            //Animal myDog = new Dog();
            ////Animal newAnimal = new Animal();
            ////newAnimal.MakeSound();
            //myDog.MakeSound();
            //myDog.Eat();

            //Animal myCat = new Cat();
            //myCat.MakeSound();
            IVehicle vehicle = new Car();
            vehicle.Start();
            vehicle.Stop();
        }
    }
}
