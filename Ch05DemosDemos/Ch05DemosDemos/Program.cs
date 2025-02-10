namespace Ch05DemosDemos {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("2.9.2025 Welcome to Chapter 5 Demos~!");

            // pg 139 relational operators
            int a = 5;
            int b = 7;
            Console.WriteLine(a=b);
            // a is now equal to 7 (b)
            string name1 = "celina";
            string name2 = "nori'";
            // boolean expression
            Console.WriteLine(name1==name2);

            // pg 141
            // is the sky blue and is temperature above 74?
            int temp = 76;
            string skyColor = "blue";

            if (skyColor=="blue"&temp>74) {
                Console.WriteLine("sky color is "+skyColor+" and temp is "+temp);
            }

            // pg 143 nested if
            // simple red, yellow and green traffic light
            // yellow light rules:
            // -- dist < 20 yards, GO
            // -- dist > 20, < 30, Speed up
            // -- dist >= 30, slow down

            string choice = "y";
            while (choice=="y") {
                Console.WriteLine("light color? (r,y,g): ");
                string lightColor = Console.ReadLine();
                if (lightColor=="r") {
                    Console.WriteLine("Stop!");
                }
                else if (lightColor=="y") {
                    Console.WriteLine("distance to light in yards? ");
                    int dist = Convert.ToInt32(Console.ReadLine());
                    string msg = "";
                    if (dist<20) {
                        msg="Go!!";
                    }
                    else if (dist<30) {
                        msg="go, but hurry! speed up!";
                    }
                    else {
                        msg="slow down!";
                    }
                    Console.WriteLine(msg);
                }
                else if (lightColor=="g") {
                    Console.WriteLine("Go!");
                }
                else {
                    Console.WriteLine("Invalid light color: "+lightColor);
                }
                Console.WriteLine("Continue? (y/n): ");
                choice=Console.ReadLine();
            }

            // switch statement
            // CRUD operations
            // create, read, update, delete
            Console.WriteLine("Movie Table - Which action to perform? ");
            string action = "";
            while (action!="exit") {
                Console.WriteLine("Menu: ");
                Console.WriteLine("==============");
                Console.WriteLine("Get: Get All Movies");
                Console.WriteLine("GID: Get Movie by ID");
                Console.WriteLine("Add: Add Movie");
                Console.WriteLine("Upd: Update Movie");
                Console.WriteLine("Del: Delete Movie");
                Console.WriteLine("Exit: Exit");
                Console.WriteLine("Action: ");
                action=Console.ReadLine().ToLower();

                switch (action) {
                    case "get":
                        Console.WriteLine(action+" was selected.");
                        break;
                    case "gid":
                        Console.WriteLine(action+" was selected.");
                        break;
                    case "add":
                        Console.WriteLine(action+" was selected.");
                        break;
                    case "upd":
                        Console.WriteLine(action+" was selected.");
                        break;
                    case "del":
                        Console.WriteLine(action+" was selected.");
                        break;
                    case "exit":
                        Console.WriteLine(action+" was selected.");
                        break;
                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }

            }

            // pg 147 case with arrow operators
            // customer type: discountPct
            // "R" - 10%
            // "C" - 20%
            // else - 0%
            string custType = "R";
            decimal discPct = 0.0m;

            discPct=custType switch {
                "R" => .1m,
                "C" => .2m,
                _ => 0m
            };
            Console.WriteLine("discPct = "+discPct);

            // pg 151 conditional experession / ternary operator
            // day of week: weekday/weekend conversion
            // day is 1 - 5: weekday, 6 or 7: weekend
            int dow = 4;
            string msg1 = "";
            if (dow<=5) {
                msg1="weekday";
            }
            else {
                msg1="weekend";
            }

            // as conditional expr
            string msg2 = (dow<=5) ? "weekday" : "weekend";
            Console.WriteLine(msg2);


            // pg 155  
            // while loop, counter and sum
            int i = 0;
            int sum = 0;
            // sum all values from 0 to 10
            while (i<=10) {
                sum+=i;
                // sum = sum+1;
                i++;
            }
            Console.WriteLine("sum = "+sum);

            // while loop for data validation
            bool success = false;
            int month = 0;
            // prompt user for month until they enter a valid month
            while (!success) {
                Console.WriteLine("Enter month: ");
                month=Convert.ToInt32(Console.ReadLine());
                if (month<1||month>12) {
                    Console.WriteLine("Invalid month #, please try again.");
                }
                else {
                    success=true;
                }
            }
            Console.WriteLine("Month entered: "+month);


            // while true
            // loop until even number is entered 
            while (true) {
                Console.WriteLine("In a while true loop ... ");
                Console.Write("Enter an even #: ");
                int nbr = Convert.ToInt32(Console.ReadLine());
                if (nbr%2==0) {
                    break;
                }
            }

            // pg 157 for loops
            // sum 0 to 10 w/ for loops
            sum=0;
            string numberStr = "";
            for (i=0; i<=10; i++) {
                sum +=i;
                numberStr+=i+" ";
                
            }
            Console.WriteLine(numberStr);
            Console.WriteLine("sum = "+sum);

            // count 0 to 100 by 5
            for (i=0; i<=10; i+=5) {
                Console.WriteLine("i: "+i);
            }
            
            // count 99 to 0 by 3
            for (i=99; i>=0; i-=3) {
                Console.WriteLine("i: "+i);
            }

            Console.WriteLine("Goodbye~");

        }
    }
}
