namespace GenericTypeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box <string> boxStr = new Box<string> ("Hello World");
            boxStr.UpdateContext("C# can be fun");
            Console.WriteLine(boxStr.GetContent());

            Action action = () =>
            {
                Console.WriteLine("Anything else we can do");
            };
            action();

            Action<int> numPrint = (x) =>
            {
                Console.WriteLine(x);
            };
            numPrint(10);

            Func<string> getName = () =>
            {
                return "Mondli";
            };
            var myName = getName();
            Console.WriteLine(myName);
        }
         
    }
}
