using ConsoleLibrary;

namespace Ch14InheritanceDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to Chapter 14 Demos - Inheritance~");

            string name = "Celina";
            MyConsole.PrintLine(name.ToString());
            MyConsole.PrintLine(name);
            // prints the same thing

            int nbr1 = 11;
            MyConsole.PrintLine(nbr1 +nbr1.ToString());

            Movie m1 = new Movie(1,"Test Movie",2000,"PG","Test Director");
            MyConsole.PrintLine(m1.ToString());
            Movie m2 = new Movie(2,"Action Movie",1998,"R","Misha Nori");
            MyConsole.PrintLine(m2.ToString());
            Movie m3 = new Movie(2,"Action Movie",1998,"R","Misha Nori");

            int nbr2 = 11;
            MyConsole.PrintLine($"nbr1 == nbr2? { nbr1==nbr2}"); //true
            MyConsole.PrintLine($"m2 == m3? {m3==m2}");

            string str1 = "abc";
            string str2 = "abc";
            MyConsole.PrintLine($"str1 == str2? {str1==str2}");

            Movie m4 = m3;
            MyConsole.PrintLine($"m3 == m4? {m3==m4}");


            // create instance
            Product p1 = new Product("c#", "Murach's C#", 54.99m);
            Product p2 = new Product();
            MyConsole.PrintLine(p1.GetDisplayText(" | "));
             
            Book b1 = new Book("java","Murach's Java",49.99m,"Joel Murach");
            MyConsole.PrintLine(b1.GetDisplayText(" | "));

            Software s1 = new Software("vs","Visual Studio",0.0m,"8.0");
            MyConsole.PrintLine(s1.GetDisplayText(" | "));

            Book b2 = new Book("c#","Murach's C#",54.99m,"Mike Murach");
            Book b3 = new Book("andr","Murach's Android",59.99m,"Joel Murach");

            // put books and software into a list and print a summary
            List<Product> products = new;
            products.Add(b1);
            products.Add(b2);
            products.Add(b3);
            products.Add(s1);
            MyConsole.PrintLine("============Product Summary============");
            foreach (Product p in products) { 
                MyConsole.PrintLine(p.GetDisplayText("|"));
            }
        }
    }
}
