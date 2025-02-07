namespace SalesReport {
    internal class Program {
        static void Main(string[] args) {
            PrintLine("Welcome to The Sales Report Application!");

            // for project 8-2 Sales Report
            decimal[,] sales = { {1540.0m, 2010.0m, 2450.0m, 1845.0m}, // Region 1
                                {1130.0m, 1168.0m, 1847.0m, 1491.0m}, // Region 2
                                {1580.0m, 2305.0m, 2710.0m, 1284.0m}, // Region 3
                                {1105.0m, 4102.0m, 2391.0m, 1576.0m}  // Region 4
            };
            decimal sum = 0.0m;

            // 1. dump data to console by region (rows), quarter (columns)
            PrintLine("Region\tQ1\tQ2\tQ3\tQ4");
            for (int i = 0; i<sales.GetLength(0); i++) {
                Print((i+1).ToString("c")+"\t");// Region Number
                for (int j = 0; j<sales.GetLength(1); j++) {
                    Print(sales[i,j].ToString("c")+"\t");
                }
                PrintLine("");
            }
            PrintLine("");
            // 2. sum sales by region (Regions 1,2,3,4)
            PrintLine("Sales by Region");
            for (int i = 0; i<sales.GetLength(0); i++) {
                Print("Region "+(i+1)+": ");
                 sum = 0.0m;
                for (int j = 0; j<sales.GetLength(1); j++) {
                    sum+=sales[i,j];
                }
                PrintLine(sum.ToString("c"));
            }
            PrintLine("");
            // 3. sum sales by quarter (Q1,Q2,Q3,Q4)
            PrintLine("Sales by Quarter");
            for (int i = 0; i<sales.GetLength(0); i++) {
                Print("Q "+(i+1)+": ");
                 sum = 0.0m;
                for (int j = 0; j<sales.GetLength(1); j++) {
                    sum+=sales[j,i];
                }
                PrintLine(sum.ToString("c"));
            }
            PrintLine("");
            // 4. total sales (sum of all data)

             sum = 0.0m;
            Print("Total Sales: ");
            
            for (int i = 0; i<sales.GetLength(0); i++) {
               
                for (int j = 0; j<sales.GetLength(1); j++) {
                    sum+=sales[i,j];
                }
            }
            PrintLine(sum.ToString("c"));
            PrintLine("");

            PrintLine("Goodbye!~");
            
        }

        static void PrintLine(string message) {
            Console.WriteLine(message);
        }
        static void Print(string message) {
            Console.Write(message);
        }
    }
}