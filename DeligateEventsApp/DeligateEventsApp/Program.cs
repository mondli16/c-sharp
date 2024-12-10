//namespace DeligateEventsApp
//{
//    internal class Program
//    {
//        //1. Declaration:

//        public delegate void Notify(string message);
//        static void Main(string[] args)
//        {
//            //Delegates define a method signature,
//            // and any method assigned a delegate must match this signature



//            //2. Instantiation:

//            Notify notify = ShowMessage;

//            //3. Invocation:

//            notify("Mondli");

//            Console.ReadKey();
//        }

//        static void ShowMessage(string message)
//        { 
//            Console.Write(message);
//        }
//    }
//}

//namespace DeligateEventsApp
//{
//    internal class Program
//    {
//        //1. Declaration:

//        public delegate void LogHandler(string message);

//        public class Logger
//        {
//            public void LogToConsole(string message)
//            {
//                Console.WriteLine("Console Log" + message);
//            }

//            public void LogToFile(string message)
//            { 
//                Console.WriteLine("File Log: "+  message);
//            }
//        }
//        static void Main(string[] args)
//        {
//            //Delegates define a method signature,
//            // and any method assigned a delegate must match this signature



//            //2. Instantiation:

//            Logger logger = new Logger();
//            LogHandler loghandler = logger.LogToConsole;

//            //3. Invocation:

//            loghandler("Loging it to console");

//            LogHandler loghander1 = logger.LogToFile;
//            loghander1("Logged file");

//            Console.ReadKey();
//        }
//    }
//}

//Sorting
//namespace DeligateEventsApp
//{
//    internal class Program
//    {

//        public delegate int Comparison<T>(T x, T y);

//        public class Person
//        {
//            public int Age { get; set; }
//            public string Name { get; set; }
//        }

//        public class PersonSorter
//        {
//            public void Sort(Person[] people, Comparison<Person> comparison)
//            {
//                for (int i = 0;i< people.Length -1; i++)
//                {
//                    for (int j = i+1; j < people.Length; j++)
//                    {
//                        if (comparison(people[i], people[j])>0)
//                        {
//                            Person temp = people[i];
//                            people[i] = people[j];
//                            people[j] = temp;

//                        }
//                    }
//                }
//            }
//        }
//        static void Main(string[] args)
//        {
//            PersonSorter sorter = new PersonSorter();

//            Person[] people =
//            {
//                new Person(){ Name = "Alice", Age = 30},
//                new Person(){ Name = "Bob", Age = 25},
//                new Person(){ Name = "Charlie", Age = 35}
//            };
//            sorter.Sort(people, CompareByAge);

//            foreach (var item in people)
//            {
//                Console.WriteLine($"{item.Name}, {item.Age}");
//            }

//            Console.ReadKey();
//        }

//        static int CompareByAge( Person x, Person y)
//        {
//            return x.Age.CompareTo(y.Age);
//        }
//    }
//}

namespace DeligateEventsApp
{

    public delegate void Notify(string message);

    public class EventPublisher
    {
        //The "On" prefix makes it immediately clear that the method
        //is associated with an event
        //It signifies that the method is not just a regular method but
        //one that is called when specidic event occurs

        public event Notify OnNotify;
        public void RaiseEvent(string message)
        { 
            OnNotify?.Invoke(message);
        }

    }

    public class EventSubscriber
    { 
        public void OnEventRaised(string message)
        {
            Console.WriteLine("Event recieved " + message);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();

            publisher.OnNotify += subscriber.OnEventRaised;

            publisher.RaiseEvent("test");
       
            Console.ReadKey();
        }
    }
}

