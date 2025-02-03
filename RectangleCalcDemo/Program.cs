namespace RectangleCalcDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rectangle Calculator App!");

            // get input - length: double, width: double
            Console.Write("Enter length: ");
            double length = Double.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            double width = Double.Parse(Console.ReadLine());
            // do business logic
            // - calc area: length*width
            // - calc perimeter: (2*length)+(2*width)
            double area = length * width;
            double perimeter = 2 * length + 2 * width; 
            // display output
            // - output area and perimeter
            Console.WriteLine("Area: "+area);
            Console.WriteLine("Perimeter: " + perimeter);



            Console.WriteLine("Bye!");
        }
    }
}
