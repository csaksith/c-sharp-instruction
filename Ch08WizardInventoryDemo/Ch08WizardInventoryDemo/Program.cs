using System.Collections;

namespace Ch08WizardInventoryDemo {
    internal class Program {
        static List<string> items = new List<string>();
        static void Main(string[] args) {
            PrintLine("Welcomne to the Wizard Inventory Game!~\n");

            items.Add("wooden staff");
            items.Add("wizard hat");
            items.Add("cloth shoes");
            string command = "";
            // while 
            while (command!="exit") {
                // display menu
                DisplayMenu();
                Print("Command: ");
                // prompt command
                command=Console.ReadLine().ToLower();
                // evaluate command: show, grab, edit, or drop item(s)
                switch (command) {
                    case "show":
                        ShowItems();
                        break;
                    case "grab":
                        GrabItem();
                        break;
                    case "edit":
                        EditItem();
                        break;
                    case "drop":
                        DropItem();
                        break;
                    // stop loop? command == "exit"
                    case "exit":
                        break;
                }
                PrintLine("");
            }
            PrintLine("Goodbye for now :) ");
        }

        private static void DropItem() {
            PrintLine("Drop an Item");
            PrintLine("--------------");
            int itemNumber = PromptInt("Item # to Drop: ",1,items.Count);
            string itemName = items[itemNumber-1];
            items.Remove(itemName);
            PrintLine($"{itemName} was removed.");
        }

        private static void EditItem() {
            PrintLine("Edit an Item");
            PrintLine("--------------");
            // prompt for item # to edit
            int itemNumber = PromptInt("Item # to edit",1,items.Count);
            // prompt for updated name
            Print("Updated name: ");
            string updatedName = Console.ReadLine();
            // edit the item at that position
            items[itemNumber-1]=updatedName;
            // display message confirming the item # was updated
            PrintLine($"Item number {itemNumber} was updated.");

        }

        private static void GrabItem() {
            PrintLine("Grab/Add an Item");
            PrintLine("--------------");
            // prompt for item to add
            if (items.Count>=4) {
                PrintLine("You can't carry any more items. Drop Something first.");
            }
            else {
                Print("Item to add: ");
                string itemName = Console.ReadLine();
                // add item to list
                items.Add(itemName);
                PrintLine($"{itemName} was added.");
            }
            
        }

        private static void ShowItems() {
            PrintLine("Show All Items");
            PrintLine("--------------");
            for (int i = 0; i<items.Count; i++) {
                PrintLine($"{i+1}. {items[i]}");
            }
        }

        static void DisplayMenu() {
            PrintLine("COMMAND MENU");
            PrintLine("====================");
            PrintLine("show - Show all items");
            PrintLine("grab - Grab an item");
            PrintLine("edit - Edit an item");
            PrintLine("drop - Drop an item");
            PrintLine("exit - Exit program");
        }

        static int PromptInt(string prompt,int min,int max) {
            int result = 0;
            bool isValid = false;
            while (!isValid) {
                // print the prompt
                Print(prompt);
                // get user input
                // TryParse for data validation
                if (Int32.TryParse(Console.ReadLine(),out result)) {
                    // validate whole number
                    // validate range
                    // >= min AND <= max
                    // < min OR > max
                    if (result>=min&&result<=max) {
                        isValid=true;
                    }
                    else {
                        PrintLine("Error - entry must be within range");
                    }
                }
            }
            return result;
        }

        static void Print(string message) {
            Console.Write(message);
        }

        static void PrintLine(string message) {
            Console.WriteLine(message);
        }

    }
}
