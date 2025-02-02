// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter first name: ");
string firstName = Console.ReadLine();

Console.WriteLine("Enter last name: ");
string lastName = Console.ReadLine();

Console.WriteLine("Enter year of birth: ");
int YOB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Welcome "+ firstName+ " "+ lastName+ '!');
Console.WriteLine("Your registration is complete");
Console.WriteLine("Your temporary password is: " + firstName+'*'+YOB);

