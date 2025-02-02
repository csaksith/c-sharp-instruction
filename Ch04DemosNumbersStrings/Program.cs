// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the Number and Strings Demos!");
int dayOfWeek = 5;
decimal price = 11.99m;
int quantity = 3;
char letter = 'A';
bool isValid = false;
quantity = 'b';
double interestRate = .0367;

//constants
const int DaysInWeek = 7;
const int DaysInNovember = 30;

//arithmetic operators
decimal lineItemTotal = price*quantity;
int count = 0;
Console.WriteLine(count);
count = count + 1;
Console.WriteLine("count = " + count);
count++;
Console.WriteLine("count = "+count);

int a = 9;
int b = 2;
int quotient = a/b;
int remainder = a % b;
Console.WriteLine("quotient = "+quotient);
Console.WriteLine("reminder = " + remainder);

double result = a / b;

double c = 9.0;
double d = 2.0;
//decimal math
result = c / d;
Console.WriteLine("result = " + result);

int counter = 10;
//increment by 1
counter = counter + 1;
counter++;
counter+=1;
Console.WriteLine("counter = "+counter);

//add 5 to counter
counter = counter + 5;
counter += 5;

//subtract 2 from counter
counter -=2;


//casting converting integer to a double
int e = 5;
double f = e;

double g = 6.7;
int h = (int)g; //explicit cast force the cast from decimal to integer 
Console.WriteLine("h = " + h);

// Math class
interestRate = .0347825;
Console.WriteLine("interestRate = "+interestRate);
//rounded to 4 decimal places
interestRate = Math.Round(interestRate,4);
Console.WriteLine("interestRate = "+interestRate);

//random number class
Random rand = new Random(); //have to create an instance of a random
int r1 = rand.Next();
Console.WriteLine("r1 = "+ r1);
int dieRoll = rand.Next(1,7);
Console.WriteLine("dieRoll = "+ dieRoll);


//strings
string firstName = "Bob";
string lastName = "Marley";
string fullName = firstName + " "+lastName;


//escape sequences - tab, newLine, backslash
string sentence = "abc\tdef\nghi";
Console.WriteLine("sentence = "+sentence);
string reposFolder = "c:\\repos";
Console.WriteLine("repos = "+reposFolder);

string rawMessage = """
hello
nice to meet you
you too
""";
Console.WriteLine(rawMessage);

//get input from the console

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine(name);



//BASIC while loop
//execute the 2 numbers and sum until user is done
string choice = "y";
while (choice == "y") {
Console.WriteLine("Enter two whole number: ");
int n1 = Convert.ToInt32(Console.ReadLine()); //method chaining from string to integer
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("sum = " + (n1 + n2));
Console.WriteLine("Continue? (y/n): ");
choice = Console.ReadLine();
//the loop will continue forever until the choice is set to "n"
}

//if statement
//discount percent
//if amount > 1000, discPct = .10
//else if amount > 800, discPct = .08
//else if amount > 500, discPct = .05
//otherwise discPct = .00
double amount = 900;
double discPct = 0.0;
if (amount >= 1000) {
        discPct = .1;
}
else if (amount >=800) {
        discPct = .08;
}
else if (amount >=500) {
        discPct = .05;
}
else {
        discPct = 0.0; //technically you don't need this because we already defined it 
}



Console.WriteLine("Goodbye");



