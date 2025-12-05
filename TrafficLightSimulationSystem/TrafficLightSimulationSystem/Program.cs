using System.Drawing;

namespace TrafficLightSimulationSystem
{
    //EventArgs
    public class TrafficLightEventArgs : EventArgs
    {
        public string Color {  get; }

        public TrafficLightEventArgs(string color)
        {
            Color = color;
        }
    }
    //Publisher
    public class TrafficLight
    {
        public event EventHandler<TrafficLightEventArgs> LightChanged;

        System.Timers.Timer timer;
        List<string> colors;
        int currentIndex = 0;
        int seconds = 5000;
        public TrafficLight()
        {
            colors = new List<string>() { "Green", "Orange", "Red" };

            timer = new System.Timers.Timer(seconds);

            timer.Elapsed += OnTimerElapsed;

            timer.Start();

            OnLightchanged(new TrafficLightEventArgs(colors[currentIndex]));
        }


        private void OnTimerElapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            // Returns the remaining number after divided by the amount of elements on the list  colors.
            // So it will reset ince it hits 3 down to 0. this way it keeps resetting
            currentIndex = (currentIndex + 1) % colors.Count;

            string CurrentColor = colors[currentIndex];

            switch (CurrentColor)
            {
                case "Green":
                    seconds = 5000; 
                    break;
                case "Orange":
                    seconds = 3000; 
                    break;
                case "Red":
                    seconds = 4000; 
                    break;
            }
            // This line updates the timer to the new duration
            timer.Interval = seconds;
            
            OnLightchanged(new TrafficLightEventArgs(CurrentColor));
        }

        protected virtual void OnLightchanged(TrafficLightEventArgs e)
        {
            LightChanged?.Invoke(this, e);
        }
    }

    // Subscriber
    public class TrafficController
    {
        // Event handler that runs when the light changes
        public void OnLightChanged(object sender, TrafficLightEventArgs e)
        {
            Console.WriteLine($"Light changed to {e.Color}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight light = new TrafficLight();
            TrafficController controller = new TrafficController();
            light.LightChanged += controller.OnLightChanged;

            Console.WriteLine("Light is Green");

            Console.ReadKey();
        }
    }
}
