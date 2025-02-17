using ConsoleLibrary;
using System.Collections.Generic;

namespace DictionaryDemo {

    internal class Program {

        private static void Main(string[] args) {
            MyConsole.PrintLine("Hello, World!");

            // 1. Declare dictionary
            // Create a dictionary to store U.S. state abbreviations as keys and their corresponding state names as values.
            Dictionary<string,string> usStates = new Dictionary<string,string>(); // create a new instance of dictionary
            // Add - adds an entry, throws expection if already exists
            usStates.Add("OH","Ohio");
            // [] Indexer - sets this position in the dictionary and replaces entry if already exists.
            usStates["IN"]="Indiana";
            MyConsole.PrintLine("Enter some US States - Enter EX to exit");
            MyConsole.PrintLine("======================================");
            string stateAbbreviation = "";
            while (stateAbbreviation!="EX") {
                stateAbbreviation=MyConsole.PromptString("US State Abbreviation: ").ToUpper();
                if (stateAbbreviation=="EX")
                    break;

                string stateName = MyConsole.PromptString("State Name: ");
                usStates[stateAbbreviation]=stateName;
                // Check if the abbreviation already exists
                
               
            }

            MyConsole.PrintLine("Get states:");
            MyConsole.PrintLine($"Key 'OH' = {usStates["OH"]}");
            //List<string> states = new List<string>(usStates.Keys);
            foreach (string s in usStates.Keys) {
                MyConsole.Print(s+", ");
            }
            MyConsole.PrintLine("");
            MyConsole.PrintLine("Display all values: ");

            foreach (string s in usStates.Values) {
                MyConsole.Print(s+", ");
            }
            MyConsole.PrintLine("");

          

            MyConsole.PrintLine("Remove an entry: \n");
            usStates.Remove("OH");
            MyConsole.PrintLine("\nKey Value Pairs");
            foreach (KeyValuePair<string,string> entry in usStates) {
                MyConsole.PrintLine($"{entry.Key} - {entry.Value}");
            }
            MyConsole.PrintLine("");
            MyConsole.PrintLine("Bye!!");
        }
    }
}