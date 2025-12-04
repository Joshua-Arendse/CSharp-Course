namespace EventsPractice
{
    //Idea: a Smart Home with different devices — like a temperature sensor, door sensor, and a central hub that receives alerts.

    public class TemperatureEventArgs : EventArgs
    {
        public int Temperature { get; }
        public TemperatureEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }

    public class DoorEventArgs: EventArgs
    {
        public bool IsOpen { get; } = false;
        public DoorEventArgs(bool isOpen)
        {
            IsOpen = isOpen;
        }
    }

    // Publishers

    public class TemperatureSensor
    {
        public event EventHandler<TemperatureEventArgs> TemperatureChanged;

        private int _temperature;

        public int Temperature 
        { 
            get { return _temperature; } 
            set
            {
                _temperature = value;
                if(_temperature > 30)
                {
                    // Raise Event
                    OnTemperatureChanged(new TemperatureEventArgs(_temperature));
                }
            }
        }

        protected virtual void OnTemperatureChanged(TemperatureEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }
    }

    public class DoorSensor
    {
        public event EventHandler<DoorEventArgs> DoorChanged;
        private bool _isOpen = false;
        public bool IsOpen
        {
            get { return _isOpen; }
            set
            {
                _isOpen = value;
                if(_isOpen)
                {
                    // Raise Event
                    OnDoorChanged(new DoorEventArgs(_isOpen));
                }
            }
        }

        protected virtual void OnDoorChanged(DoorEventArgs e)
        {
            DoorChanged?.Invoke(this, e);
        }
    }

    // Subscriber

    public class SmartHomeHub
    {
        public void OnTemperatureChanged(object sender, TemperatureEventArgs e)
        {
            Console.WriteLine($"Alert: temperature is too high! It is {e.Temperature} Degrees. Sender is: {sender}");
        }

        public void OnDoorOpened(object sender, DoorEventArgs e)
        {
            Console.WriteLine("Alert the Door is open!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureSensor tempSensor = new TemperatureSensor();
            DoorSensor doorSensor = new DoorSensor();
            SmartHomeHub Hub = new SmartHomeHub();
            tempSensor.TemperatureChanged += Hub.OnTemperatureChanged;
            doorSensor.DoorChanged += Hub.OnDoorOpened;

            tempSensor.Temperature = 35;
            doorSensor.IsOpen = true;


            Console.ReadKey();
        }
    }
}
