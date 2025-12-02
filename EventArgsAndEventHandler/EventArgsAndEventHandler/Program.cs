using System;
namespace EventArgsAndEventHandler
{
    // Using the Generic Delegate EventHandler<TEventArgs>

    //public delegate void TemperatureChangeHandler(string message);

    public class TemperatureChangedEventArgs : EventArgs
    {
        //Property holding the temperature
        public int Temperature {  get; }

        // Constructor
        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }

    public class TemperatureMonitor
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        //public event TemperatureChangeHandler OnTemperatureChanged;
        private int _temperature;
        public int Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    //Raise Event
                    //OnTemperatureChangedEvent(new TemperatureChangedEventArgs(_temperature));
                    OnTemperatureChangedEvent(_temperature);
                }
            }
        }

        //protected virtual void OnTemperatureChangedEvent(TemperatureChangedEventArgs e)
        //{
        //    //Letting every subscriber know
        //    TemperatureChanged?.Invoke(this,e);
        //}
        protected virtual void OnTemperatureChangedEvent(int temp)
        {
            //Letting every subscriber know
            TemperatureChanged?.Invoke(this,new TemperatureChangedEventArgs(temp));
        }
    }
    //Subscriber
    public class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Alert: temperature is {e.Temperature} sender is: {sender}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            monitor.TemperatureChanged += alert.OnTemperatureChanged;

            monitor.Temperature = 20;
            Console.WriteLine("Please enter the temperature");
            monitor.Temperature = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}