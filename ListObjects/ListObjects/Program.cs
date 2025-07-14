namespace ListObjects
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a list of complex objects with initial values
            List<Product> products = new List<Product>
            {
                new Product { Name = "Apple", Price = 0.80},
                new Product { Name = "Banana", Price = 0.30},
                new Product { Name = "Cherry", Price = 3.80}
            };
            // add items to the list
            products.Add(new Product { Name = "Berry", Price = 2.99 });

            Console.WriteLine("Available Products: ");

            // itterate through the list
            foreach (Product product in products)
            {
                Console.WriteLine($"Product name: {product.Name} for R{product.Price}.");
            }
            
            //Linq
            List<Product> cheapProducts = products.Where(p => p.Price < 1.0).ToList(); //Filtered the list

            Console.WriteLine("Avaliable products under R1.");

            foreach (Product product in cheapProducts)
            {
                Console.WriteLine($"Product name: {product.Name} for R{product.Price}.");
            }

            Console.ReadKey();
        }
    }
}
