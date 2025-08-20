using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS2.Classes
{
    abstract class Employee
    {
        protected string name;
        private double salary;
        public double Salary
        {
            get { return salary; }
            set { 
                if (value < 0)
                {
                    Console.WriteLine("Salary cannot be negative.");
                    salary = 30000;
                }
                else
                {
                    salary = value;
                }
            }
        }

        public abstract void Work();
        protected double GetSalary()
        {
            return salary;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Salary: {GetSalary()}");
        }
    }
    class Manager : Employee
    {
        private string department;
        public Manager(string name, double salary, string department)
        {
            this.name = name;
            this.department = department;
            this.Salary = salary;
        }
        public override void Work()
        {
            Console.WriteLine($"Manager {name} is managing the {department} department");
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Department: {department}, Salary: {GetSalary()}");
        }
    }
    interface ICoder
    {
        void Code();
    }
    class Developer : Employee, ICoder
    {
        private string programmingLanguage;
        public Developer(string name,double salary, string programmingLanguage)
        {
            this.name=name;
            this.Salary=salary;
            this.programmingLanguage = programmingLanguage;
        }
        public override void Work()
        {
            Console.WriteLine($"Developer {name} is coding in {programmingLanguage}");
        }
        void ICoder.Code()
        {
            Console.WriteLine($"{name} is coding in {programmingLanguage}");
        }
    }
}
