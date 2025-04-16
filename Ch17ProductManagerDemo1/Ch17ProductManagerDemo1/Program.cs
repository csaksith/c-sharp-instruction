using ConsoleLibrary;

namespace Ch17ProductManagerDemo1 {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Hello, World!\n");
            string dir = @"C:\C#\Files\";
            if (!Directory.Exists(dir)) {
                Directory.CreateDirectory(dir);
                MyConsole.PrintLine("dir created!");
            }

            else {
                MyConsole.PrintLine("dir aleady exists");
            }

            string path = dir+"names.txt";
            if (!File.Exists(path)) {
                File.Create(path);
                MyConsole.PrintLine("file created!~");

            }
            else {
                MyConsole.PrintLine("file already exists.");
            }


            MyConsole.PrintLine("Goodbye~");

        }
    }
}



