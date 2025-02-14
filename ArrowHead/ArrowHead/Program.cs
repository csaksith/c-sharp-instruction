namespace ArrowHead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Arrowhead generator!~");
            Console.Write("Enter the size of arrowhead: ");
            int aSize = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<aSize; i++) {
                Console.WriteLine(">");
            }
            Console.WriteLine("Goodbye~");
        }
    }
}
