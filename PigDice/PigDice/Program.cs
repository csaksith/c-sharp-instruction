using PigDice;

MyConsole.PrintLine("Welcome to the Piggy Dice Game!~");
GameStats stats = new GameStats();

string choice = "y";
while (choice=="y") {
    Console.Write("Enter the number of games to play: ");
    if (int.TryParse(Console.ReadLine(),out int gamesToPlay)){
        stats.StartTrackingTime();
        for (int i = 0; i<gamesToPlay; i++) {
            GameClass gameClass = new GameClass();
            stats.UpdateStats(gameClass);
        }
        stats.StopTrackingTime();
        stats.DisplayStats();
    }
    else {
        MyConsole.PrintLine("Invalid input. Please enter a valid number.");
    }
    choice=MyConsole.PromptString("Play again? (y/n): ");
}
MyConsole.PrintLine("Thanks for playing, bye~");
