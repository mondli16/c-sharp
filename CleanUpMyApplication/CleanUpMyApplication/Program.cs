namespace CleanUpMyApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bad practise

            int n = 0;
            string s = "John";

            //good practise

            int studentCount = 100; //Camel Case
            string studentName = "Mondli"; //Camel Case


            OrderProcessor orderProcessor = new OrderProcessor();


        }

        class CustomerService //PastalCase
        {
            public const int MAx_CUSTOMERS = 100; //ALL CAPS
            public int CustomerCount { get; set; } //PastalCase

            public string CustomerName() //PastalCase and parameters are written in CamelCase
            {
                return "";
            }
        }

        //Naming Classes

        class OrderProcessor
        {
            public void ProcessOrder() //Use verbs
            {

            }
            public void PrintOrder() //Use verbs
            {

            }
            public void DeleteOrder() //Use verbs
            {

            }

            //Naming booleans

            private bool hasErrors = false; //declare as true or false question (use is or has)
            private bool isValid = true; //declare as true or false question(use is or has)

        }
    }
}
