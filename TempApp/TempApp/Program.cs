namespace TempApp
{
    internal class Program
    {
        public delegate void TemperatureChagedHandler(string message);

        public class TemperatureMonitor
        {
            public TemperatureChagedHandler OnTemperatureChanged;    
            private int _temperature;

            public int Temparature
            {
                get { return _temperature; }
                set
                {
                    _temperature = value;
                    if (_temperature > 30)
                    {
                        // RAISE EVENT!!
                        RaiseTemperatureChangedEvent("Temperature is above threshold!");
                    }
                }
            }

            protected virtual void RaiseTemperatureChangedEvent(string message)
            { 
                OnTemperatureChanged?.Invoke(message);
            }
        }

        public class TempearatureAlert
        {
            public void OnTemperature(string message) 
            {
                Console.WriteLine("Alert: " + message);
            }
        }

        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TempearatureAlert alert = new TempearatureAlert();
            monitor.OnTemperatureChanged += alert.OnTemperature;

            Console.WriteLine("Please enter temperature");
            monitor.Temparature = int.Parse(Console.ReadLine());


            Console.ReadKey();
        }
    }
}
