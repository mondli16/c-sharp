using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    //Internal means this class can only be used in this project
    internal class Car
    {
        public static int NumberOfCars = 0;
        //member variable - a field inside the class but outside of methods

        //privates hides the variable from other classes
        //modified only in the same class
        //private string _model = "";
        //private string _brand = "";

        //Property
        public string Model { get; set; }
        public string Brand { get; set; }


        //Contructer
        // Like a method but doesnt return anything
        public Car(string model, string brand) {
        
            Model = model;
            Brand = brand;
            Console.WriteLine($"An object of {Model} {Brand } has been created");
        }

        public void Drive() 
        {
            Console.WriteLine("I am driving");
        }
    }
}
