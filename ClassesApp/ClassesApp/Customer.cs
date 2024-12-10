using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Customer
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        //Backing field for write-only property
        private string _password;

        //Backing field for write-only property 
        public string Password { set
            {
                _password = value;
            }
        }

        //Write-Only property
        

        private static int nextId = 0;

        //Read-only instance field initialized from constructor
        private readonly int _id; 

        //Custom Contructor

        public Customer(string name, string address, string contact)
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contact;
        }

        public Customer(string name)
        {
            _id = nextId++;
            Name = name;
        }

        public Customer()
        {
            _id = nextId++;
            Name = "DefaultName";
            Address = "No Address";
            ContactNumber = "No ContactNumber";
        }

        public void SetDetails(string name, string address, string contact)
        {
 
            Name = name;
            Address = address;
            ContactNumber = contact;
        }
        //Static is the method that doesnt need to be called on an object
        public static void DoSomething() 
        {
            Console.WriteLine("Im doing something");
        }

        public void ReadDetails()
        {
            Console.WriteLine($"Details about customer is {Name} and id is {_id} and password is {_password}");
        }
    }
}
