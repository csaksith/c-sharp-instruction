using ConsoleLibrary;

namespace Ch15InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to Chapter 15 - Intefaces~\n");
            List<Summarizable> things = new List<Summarizable>();
            // create some products
            Product p1 = new Product("c#", "Murach's C#", 53.99m);
            Product p2 = new Product("mysql", "Murach's MySQL", 44.99m);
            Product p3 = new Product("andr", "Murach's Android", 59.99m);
            things.Add(p1);
            things.Add(p2);
            things.Add(p3);

            // create some customers
            Customer c1 = new Customer("Adrian", "Johnson", "AJ0001");
            Customer c2 = new Customer("Celina", "Saksith", "CS0020");
            things.Add(c1);
            things.Add(c2);


            // print summary
            MyConsole.PrintLine("Summary: ");
            foreach (var item in things) {
                MyConsole.PrintLine($"{item.GetSummaryDetails()}");
            }
            // we need a GetSummaryDetails()  method on these classes

            // sort list of products
            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            MyConsole.PrintLine("=== All Products ===");
            foreach (var item in things)
            {
                MyConsole.PrintLine(item.GetSummaryDetails());
            }

            // sort products
            products.Sort();

            MyConsole.PrintLine("=== Sorted Products ===");
            foreach (var product in products)
            {
                MyConsole.PrintLine(product.GetSummaryDetails());
            }
            Console.ReadLine();
            MyConsole.PrintLine("Bye~");
        }
    }
}
