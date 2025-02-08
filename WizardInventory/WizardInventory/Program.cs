using System.Reflection.Metadata;

namespace WizardInventory {
    internal class Program {
        static void Main(string[] args) {
            PrintLine("~The Wizard Inventory Game!~");
            PrintLine("");

            // list for starting items
            // wooden staff, wizard hat, cloth shoes
            // max inventory is 4 items at a time
            // user input: command (show, grab, edit, drop, exit)
            // edit and drop command
            // display message if user enters an invalid number for item
            PrintLine("COMMAND MENU\nshow - Show all items\ngrab - Grab an item\nedit - Edit an item\ndrop - Drop an item\nexit - Exit program");


            List<string> myItems = new List<string>();
            myItems.Add("wooden staff");
            myItems.Add("wizard hat");
            myItems.Add("cloth shoes");

            List<string> inventoryItems = new List<string>();
            inventoryItems.Add("wooden staff");
            inventoryItems.Add("wizard hat");
            inventoryItems.Add("cloth shoes");
            inventoryItems.Add("potion of invisibility");

            string command = "";
            while (command!="exit") {
                Print("Command: ");

                command=Console.ReadLine();
                // show command
                if (command=="show") {
                    for (int i = 0; i<myItems.Count; i++) {
                        PrintLine($"{i+1}.{myItems[i]}");
                    }
                }
                else if (command=="grab") {
                    if (myItems.Count>=4) {
                        PrintLine("You can't carry any more items. Drop something first.");
                    }
                    else {
                        Print("Name: ");
                        string newItem = Console.ReadLine();
                        // add new item to inventory items
                        myItems.Add(newItem);
                        PrintLine($"{newItem} was added.");
                    }
                }
                else if (command=="edit") {

                    PrintLine("Number: ");
                    int number = Int32.Parse(Console.ReadLine());
                    while (!int.TryParse(Console.ReadLine(),out number)||number<1||number>4) {
                            PrintLine("Invalid: Choose a number between 1 - 4,");
                            continue;
                        }


                    PrintLine("Updated name: ");
                    string updatedName = Console.ReadLine();
                    myItems[number-1]=updatedName;
                    PrintLine($"Item number {number} was updated.");

                }
                else if (command=="drop") {
                    Print("Number: ");
                    int number = Int32.Parse(Console.ReadLine());
                    string itemToRemove = myItems[number-1];
                    myItems.Remove(itemToRemove);
                    PrintLine($"{itemToRemove} was dropped.");
                }
                else if (command=="exit") {
                    PrintLine("");
                    PrintLine("~Goodbye~");
                }






            }

            static void Print(string message) {
                Console.Write(message);
            }
            static void PrintLine(string message) {
                Console.WriteLine(message);
            }
        }
    }
}
