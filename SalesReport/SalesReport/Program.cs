namespace SalesReport {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("The Sales Report Application");

            // for project 8-2 Sales Report
            double[,] sales = { {1540.0, 2010.0, 2450.0, 1845.0},
                                {1130.0, 1168.0, 1847.0, 1491.0},
                                {1580.0, 2305.0, 2710.0, 1284.0},
                                {1105.0, 4102.0, 2391.0, 1576.0}};

            // grid 5 x 5
            // Region   Q1  Q2  Q3  Q4
            // 1
            // 2
            // 3
            // 4
            string[,] grid = new string[5,5];
            grid[0,0]="Region";
            grid[0,1]="Q1";
            grid[0,2]="Q2";
            grid[0,3]="Q3";
            grid[0,4]="Q4";
            grid[1,0]="1";
            grid[2,0]="2";
            grid[3,0]="3";
            grid[4,0]="4";

            // print grid for titles;
            string gridString = "";
            for (int i = 0; i<grid.GetLength(0); i++) {
                for (int j = 0; j<grid.GetLength(1); j++) {
                    gridString+=grid[i,j]+"\t";
                }
                gridString+="\n";
            }
            // add sales data into the grid
            for (int i = 0; i<sales.GetLength(0); i++) {
                for (int j = 0; j<sales.GetLength(1); j++) {
                    grid[i+1,j+1]=sales[i,j].ToString("C");
                }
            }

            for (int i = 0;i<sales.GetLength(0); i++) {
                for (int j = 0; j<sales.GetLength(1); j++) {
                    Console.Write(grid[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Goodbye!~");

        }
    }
}
