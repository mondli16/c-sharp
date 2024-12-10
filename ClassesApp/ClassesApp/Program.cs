namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an object using a blueprint of car
            // Creating an object of a class car
            // or instant of a class
            //Car audi = new Car("Oddi", "Audi");
            //Car bwm = new Car("performance", "BMW");
            //Console.WriteLine("Hello, World!");

            //Customer mondli = new Customer("Mondli");
            //Customer frankTheTank = new Customer("frankTheTank", "25 Nzuzo Road", "0682464407");
            //mondli.Name = "Mondli";


            //Customer myCustomer = new Customer();
            //Console.WriteLine("Name of the customer is "+ mondli.Name);
            //Console.WriteLine($"{myCustomer.Name}");

            //Car myAudi = new Car("A3", "Audi");
            //myAudi.Drive();

            //Customer myCustomer = new Customer();
            //myCustomer.SetDetails("Mondli", "G416", "545446858");
            //Console.WriteLine($"{myCustomer.Name} {myCustomer.Address} {myCustomer.ContactNumber}");



            //Customer.DoSomething() ;

            Customer customer = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();
            customer.ReadDetails();
            customer2.ReadDetails();
            customer3.Password = "12083qwertyu$%";
            customer3.ReadDetails();
        }
    }
}
