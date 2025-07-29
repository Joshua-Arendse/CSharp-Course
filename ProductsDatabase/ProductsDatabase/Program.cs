namespace ProductsDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Challenge
             * Create a Product class with Name, Price, and Stock.
               Store 5+ products in a List<Product>.
               Use LINQ to:
               -Show all products with stock > 10
               -Show the most expensive product
            */

            List<Product> shop = new List<Product>
            {
                new Product{Name="Fish",Price=50.0,Stock=8},
                new Product{Name="Chicken",Price=100.0,Stock=10},
                new Product{Name="Beef",Price=200.0,Stock=5},
                new Product{Name="Halls",Price=0.50,Stock=50},
                new Product{Name="Chips",Price=5.0,Stock=12}
            };

            var popularProducts = shop.Where(x => x.Stock > 10).ToList();

            foreach(var item in popularProducts)
            {
                Console.WriteLine(item.Name);
            }

            var mostExpensive = shop.OrderByDescending(x => x.Price).First();
            Console.WriteLine($"{mostExpensive.Name}, R{mostExpensive.Price}");


            Console.ReadKey();

        }

        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Stock { get; set; }
        }

    }
}
