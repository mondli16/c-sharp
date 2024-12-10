using System.Net.Http.Headers;

namespace threadsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World! 1");
            //Thread.Sleep(1000);

            //Console.WriteLine("Hello, World! 2");
            //Thread.Sleep(1000);

            //Console.WriteLine("Hello, World! 3");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello, World! 4");
            //Thread.Sleep(1000);

            //Console.WriteLine("Hello, World! 5");
            //Thread.Sleep(1000);

            //new Thread(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("TThread 1");
            //}).Start();

            //new Thread(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("TThread 2");
            //}).Start();

            //new Thread(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("TThread 3");
            //}).Start();

            //new Thread(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("TThread 4");
            //}).Start();

            var taskCompletionSource = new TaskCompletionSource<bool>();

            var thread = new Thread(() => 
            { 
                Thread.Sleep(1000);
                taskCompletionSource.TrySetResult(true);
            });
            Console.WriteLine(thread.ManagedThreadId);
            thread.Start();
            var test = taskCompletionSource.Task.Result;

            

         
        }
    }
}
