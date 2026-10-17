namespace EventsPractise2
{
    internal class Program
    {
        public class StockPriceChangedEventArgs : EventArgs
        {
            public string StockName { get; }
            public decimal NewPrice { get; }
            public StockPriceChangedEventArgs(string stockName, decimal newPrice)
            {
                StockName = stockName;
                NewPrice = newPrice;
            }
        }

        public class Stock(string stockName, decimal initialPrice)
        {
            public event EventHandler<StockPriceChangedEventArgs> PriceChanged;
            private string _StockName = stockName;
            private decimal _Price = initialPrice;


            public string StockName { get { return _StockName; } }
            public decimal Price
            {
                get { return _Price; }
                set
                {
                    if (value != _Price)
                    {
                        _Price = value;
                        OnPriceChanged(new StockPriceChangedEventArgs(StockName, Price));
                    }
                }
            }

            protected virtual void OnPriceChanged(StockPriceChangedEventArgs e)
            {
                PriceChanged?.Invoke(this, e);
            }
        }

        public class PriceAlert
        {
            public decimal Threshold { get; }
            public PriceAlert(decimal threshold)
            {
                Threshold = threshold;
            }

            public void OnPriceChanged(object sender, StockPriceChangedEventArgs e)
            {
                if (e.NewPrice > Threshold)
                {
                    Console.WriteLine($"Warning: The price of {e.StockName} is too high at {e.NewPrice}");
                    var stock = (Stock)sender; //casting sender to stock
                    stock.PriceChanged -= this.OnPriceChanged; // Unsubscribing once it hits the threshold
                }
            }
        }

        public class DashBoard
        {
            public void OnPriceChanged(object sender, StockPriceChangedEventArgs e)
            {
                Console.WriteLine($"{e.StockName} updated: new price = {e.NewPrice}");
            }
        }

        static void Main(string[] args)
        { 
            Stock stock = new Stock("Gold",69);
            PriceAlert priceAlert = new PriceAlert(100); //Threshold is 100
            DashBoard dashBoard = new DashBoard();

            stock.PriceChanged += priceAlert.OnPriceChanged;
            stock.PriceChanged += dashBoard.OnPriceChanged;

            stock.Price = 88;
            stock.Price = 90;
            stock.Price = 99;
            stock.Price = 120;

            Console.ReadKey();
        }
    }
}

