using System.ComponentModel;

namespace inheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog myDog = new Dog();
            // myDog.Bark();
            // myDog.Eat();

            Employee joe = new Employee("Joe", 36, "Sales Rep",12345);
            joe.DisplayPersonInfo();
        }
    }
    //Single inheritance
    //Base class (ParenthesizePropertyNameAttribute Class or SuperClass):  The class whose members inherited
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    //Derived Class(Child Class or SubClass): Thhe class inherits the members of the members of the base class

    //class Dog : Animal
    //{
    //    public void Bark()
    //    {
    //        Console.WriteLine("Barking...");
    //    }
    //}

    //added this for multi inheritance
    //class Collie : Dog 
    //{
    //    public void GoingNuts()
    //    {
    //        Console.WriteLine("Collie going nuts");
    //    }
    //}

    //The other one multi classes inherit from one base class

    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Person(string name, int age) 
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person constructor called");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    public class Employee : Person
    {
        public string JobTitle { get; set; }
        public int EmployeeId { get; set; }
        public Employee(string name, int age, string jobTitle, int employeeID) : base(name, age)
        {
            JobTitle = jobTitle;
            EmployeeId = employeeID;
            Console.WriteLine($"Employee constructor called {Name}");
        }
             
    }
}
