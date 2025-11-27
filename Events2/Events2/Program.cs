namespace Events2
{
    public delegate void TemperatureChangeHandler(string message);

    public class TemperatureMonitor
    {
        public event TemperatureChangeHandler OnTemperatureChanged;
        private int _temperature;
        public int Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                if (_temperature > 30)
                {
                    //Raise Event
                    RaiseTemperatureChangedEvent("Temperature is above threshhold!");
                }
            }
        }

        protected virtual void RaiseTemperatureChangedEvent(string message)
        {
            OnTemperatureChanged?.Invoke(message);
        }
    }
    public class TemperatureAlert
    {
        public void OnTemperatureChanged(string message)
        {
            Console.WriteLine("Alert: " + message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            monitor.OnTemperatureChanged += alert.OnTemperatureChanged;

            monitor.Temperature = 20;
            Console.WriteLine("Please enetr the temperature");
            monitor.Temperature= int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
