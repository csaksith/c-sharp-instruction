namespace Ch12ClassesDemo {
    internal class Program {
        static List<Movie> Movies = new List<Movie>();
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Chapter 12 - Class Demo!");
            // capture input for properties of a movie

            Movie newMovie = new Movie();
            newMovie.Id=1;
            newMovie.Title="Jurassic Park";
            newMovie.Year=2025;
            newMovie.Rating="PG-13";
            newMovie.Director="Gareth Edwards";
            Movies.Add(newMovie);
            string choice = "y";
            while (choice=="y") {
                int id = MyConsole.PromptInt("Movie ID: ");
                string title = MyConsole.PromptString("Movie Title: ");
                int year = MyConsole.PromptInt("Year: ");
                string ageRating = MyConsole.PromptString("Age rating: ");
                string director = MyConsole.PromptString("Director: ");
                // store this movie and capture a new one
                newMovie=new Movie(id,title,year,ageRating,director);
                Movies.Add(newMovie);
                choice=MyConsole.PromptString("Add another movie? (y/n): ");
                // repeat until user is done entering movies
            }
            // display all movies
            // getter

            ////setter
            //PrintLine($"newMovie title = {newMovie.Title}");
            //PrintLine(newMovie.ToString());


            // store this movie and capture a new one
            // repeat until user is done entering movies
            // display all movies
            MyConsole.PrintLine("========== MOVIES ========");
            foreach (Movie movie in Movies) {
                MyConsole.PrintLine(movie.ToString());
            }
            Console.WriteLine("BYE!");
        }
       
    }
}
