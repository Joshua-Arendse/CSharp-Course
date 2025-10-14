namespace StructsExercise
{
    // Define the Event struct with necessary fields and methods
    public struct Event
    {
        public DateTime StartDate; // Public field to store the start date of the event
        public DateTime EndDate; // Public field to store the end date of the event

        // Constructor to initialize the fields
        public Event(DateTime startDate, DateTime endDate)
        {
            // Throw an exception if the start date is not before the end date
            if (startDate >= endDate)
                throw new ArgumentException("StartDate must be before EndDate");

            StartDate = startDate;
            EndDate = endDate;
        }

        // Method to get the duration of the event in days
        public double GetDuration()
        {
            // Calculate the difference between EndDate and StartDate and return TotalDays
            return (EndDate - StartDate).TotalDays;
        }

        // Method to check if this event overlaps with another event
        public bool IsOverlapping(Event otherEvent)
        {
            // Two events overlap if one's start date is before the other's end date
            // and one's end date is after the other's start date
            return StartDate < otherEvent.EndDate && EndDate > otherEvent.StartDate;
        }
    }
            
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two Event instances with different dates
            Event event1 = new Event(new DateTime(2024, 7, 1), new DateTime(2024, 7, 10));
            Event event2 = new Event(new DateTime(2024, 7, 5), new DateTime(2024, 7, 15));

            // Print the duration of each event
            Console.WriteLine($"Event 1 Duration: {event1.GetDuration()} days");
            Console.WriteLine($"Event 2 Duration: {event2.GetDuration()} days");

            // Check and print whether the events overlap
            Console.WriteLine($"Events Overlap: {event1.IsOverlapping(event2)}");

            Console.ReadKey();
        }
    }
}
