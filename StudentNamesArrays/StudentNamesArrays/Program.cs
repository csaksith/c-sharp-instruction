using ConsoleLibrary;

namespace StudentNamesArrays {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Studetn Array App~\n");


            // prompt user for number of students
            int nbrStudents = MyConsole.PromptInt("Number of Students?: ");
            string[] studentArray = new string[nbrStudents]; // declare array


            // for loop to loop through studentArray
            for (int i = 0; i<nbrStudents; i++) {
                // for each position in the array
                // - prompt name initialize variable
                string name = MyConsole.PromptString($"Student Name[{i}]: "); // so we know what position in the array we are in
                // - add name to studentArray
                studentArray[i]=name; // set that position in the array based on what the student enter
            }
            // print the array on one line -- one method
            //string names = "";
            //foreach (string name in studentArray) {
            //names += name+"|";
            //}
            //MyConsole.PrintLine();
            //MyConsole.PrintLine(names);

            // another method to print array
            //foreach (string n in studentArray) {
            //    MyConsole.Print(n+"|");
            //}
            //MyConsole.PrintLine();

            // another method to print array - lambda
            Array.Sort(studentArray);
            Array.ForEach(studentArray, student => Console.Write(student+"|"));
            MyConsole.PrintLine();
            MyConsole.PrintLine("\nBye~!");



        }
    }
}
