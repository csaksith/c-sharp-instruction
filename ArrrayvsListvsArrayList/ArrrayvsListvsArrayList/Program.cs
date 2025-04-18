﻿using ConsoleLibrary;
using System;

namespace ArrrayvsListvsArrayList {

    internal class Program {

        private static void Main(string[] args) {
            MyConsole.PrintLine("Arrays, Lists, ArrayLists! OH MY~\n");

            // process a set of numbers 1 to 10, using arrays
            int[] numbers = { 1,2,3,4,5,6,7,8,9,10 };
            // foreach loop if index is not needed
            string outputStr = "";
            int sum = 0;
            foreach (int i in numbers) {
                outputStr+=i.ToString()+" ";
                sum+=i;
            }

            MyConsole.PrintLine(outputStr);
            MyConsole.PrintLine($"sum = {sum}");

            // add 11 through 15?
            numbers=numbers.Append(11).ToArray();

            Array.ForEach(numbers,(i) => { MyConsole.Print(i.ToString()+" "); });
            MyConsole.PrintLine();
            // change an element within an array, at position 5, multiple value by 10?
            numbers[5]=numbers[5]*10;
            Array.ForEach(numbers,(i) => { MyConsole.Print(i.ToString()+" "); });

            MyConsole.PrintLine("\n~~~LIST~~~");
            List<int> nums = new List<int> { 1,2,3,4,5,6,7,8,9,10 };
            sum=0;
            string numsStr = "";
            foreach (int i in nums) {
                numsStr+=$"{i}, ";
                sum+=i;
            }
            numsStr=numsStr.Substring(0,numsStr.Length-2);
            MyConsole.PrintLine(numsStr);
            MyConsole.PrintLine($"\nsum = {sum}");
            // add 11 to the end
            nums.Add(11);
            nums.ForEach(num => { MyConsole.Print($"{num}, "); });
            MyConsole.PrintLine();

            // change an element within a list, at position 5, multiply value by 10
            nums[5]=nums[5]*10;
            nums.ForEach(num => { MyConsole.Print($"{num}, "); });
            MyConsole.PrintLine();

            // delete at position 5
            nums.RemoveAt(5);
            nums.ForEach(num => { MyConsole.Print($"{num}, "); });
            MyConsole.PrintLine();

            // create some product instances
            Product p1 = new Product(1,"c#","Murach's C#",54.99m);
            Product p2 = new Product(2,"java","Murach's Java",55.99m);
            Product p3 = new Product(3,"mysql","Murach's MySQL",45.99m);

            List<Product> products = new List<Product> { p1,p2,p3 };
            //foreach (Product p in products) {
            //    MyConsole.PrintLine(p.ToString());
            //}
            // CRUD on a list
            //  - adding an element to the list
            Product p4 = new Product(99,"test","Test Book",11.11m);
            products.Add(p4);
            products.ForEach(p => MyConsole.PrintLine(p.ToString())); // - get an element from list w code 99
            Product p = null;
            foreach (Product prod in products) {
                if (prod.ProductID==99) {
                    p=prod;
                    break;
                }
            }
            MyConsole.PrintLine($"Product Found!: {p.ToString()}");
            // update an element in the list - update the code to TEST for id 99
            foreach (Product prod in products) {
                if (prod.ProductID==99) {
                    prod.Code="TEST";
                    break;
                }
            }
            products.ForEach(p => MyConsole.PrintLine(p.ToString()));
            // - delete an element from the list - id 99
            foreach (Product prod in products) {
                if (prod.ProductID==99) {
                    products.Remove(prod);
                    break;
                }
            }
            products.ForEach(p => MyConsole.PrintLine(p.ToString()));


            //Product.ForEach(p => MyConsole.PrintLine(p.ToString())); lambda version


            MyConsole.PrintLine("\nBYE~");
        }
    }
}