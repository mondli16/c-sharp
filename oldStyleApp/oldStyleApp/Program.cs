
// used to organize code
namespace oldStyleApp
{

    //Name of the class
    internal class Program
    {
        //static can be called directly from the class   
        static void Main(string[] args)
        {
            int myResult;

            

            
            Console.WriteLine("Enter a number, I'll add 10 to it");
            int number = 0;
            int num1 = int.Parse(Console.ReadLine());

            myResult = AddTwoValues(num1, 10);
            Console.WriteLine("The result is"+ myResult);
            Console.ReadKey();
        }

        static int AddTwoValues(int value1, int value2)
        {
            int result = value1 + value2;
            return result;
        }
        static int SubtractTwoValues(int value1, int value2)
        {
            int result = (value1 - value2);
            return result;
        }
    }
}
