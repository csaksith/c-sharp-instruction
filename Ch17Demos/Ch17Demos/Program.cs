using ConsoleLibrary;

namespace Ch17Demos {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the file demo~\n");
            string dir = @"C:\C#\Files\";
            if (!Directory.Exists(dir)) {
                Directory.CreateDirectory(dir);
                MyConsole.PrintLine("Directory Created~");
            }
            else {
                MyConsole.PrintLine("Directory already exists.");
            }

            string path = dir+"names.txt";
            if (!File.Exists(path)) {
                File.Create(path);
                MyConsole.PrintLine("File Created~");
            }
            else {
                MyConsole.PrintLine("File already exists.");
            }
            //// write some names to our file...
            //// create new instance of file stream
            //StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            //writer.WriteLine("Celina");
            //writer.WriteLine("Heath");
            //writer.WriteLine("Nick");
            //writer.WriteLine("Heath");
            //writer.WriteLine("Drew");
            //writer.Close();
            //MyConsole.PrintLine("Names writing done!~");

            MyConsole.PrintLine("=== reading names.txt ===");
            StreamReader reader = new StreamReader(
            new FileStream(path,FileMode.OpenOrCreate,FileAccess.Read));
            List<string> lines = new List<string>();
            while (reader.Peek()!=-1) {
                string row = reader.ReadLine()??"";
                lines.Add(row);
            }
            reader.Close();
            foreach (string line in lines) {
                MyConsole.PrintLine($"line = {line}");
            }

            MyConsole.PrintLine("goodbye.");
        }
    }
}

