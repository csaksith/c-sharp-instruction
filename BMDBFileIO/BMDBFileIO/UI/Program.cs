using ConsoleLibrary;

namespace BMDBFileIO {

    public class Program {
        private static List<Movie> movies = new List<Movie>();
        private static string filePath = "movies.txt";

        private static void Main(string[] args) {
            Console.WriteLine("Welcome to the Bootcamp Movie ");
            //Movie m1 = new Movie(1,"Spaceballs",1985,"PG","Mel Brooks");
            //Movie m2 = new Movie(2,"Totally Awesome",2025,"PG-13","Sean Blessing");

            List<Movie> movies = new List<Movie>();
            //movies.Add(m1);
            //movies.Add(m2);
            //MovieDB.SaveMovies(movies);

            movies=MovieDB.GetMovies();
            //foreach (Movie movie in movies) {
            //    MyConsole.PrintLine(movie.ToString());
            //}

            movies.ForEach(m => m.Title+="!");
            movies.ForEach(m => MyConsole.PrintLine(m.ToString()));

            MyConsole.PrintLine("Bye!!!");
        }
    }
}
//int command = -1;
//while (command!=0) {
//    MyConsole.PrintLine("=== Movie Menu ===");
//    MyConsole.PrintLine("1) List All Movies");
//    MyConsole.PrintLine("2) Get Movie by ID");
//    MyConsole.PrintLine("3) Add Movie");
//    MyConsole.PrintLine("4) Delete Movie by ID");
//    MyConsole.PrintLine("0) Exit");
//        command=MyConsole.PromptInt("Enter your choice");

//        switch (command) {
//            case 1:
//                ListAllMovies();
//                break;

//            case 2:
//                GetMovieByID();
//                break;

//            case 3:
//                AddMovie();
//                break;

//            case 4:
//                DeleteMovieByID();
//                break;

//            case 0:
//                SaveMoviesToFile(); // Save movies before exiting
//                break;

//            default:
//                Console.WriteLine("Invalid command. Please try again.");
//                break;
//        }
//    }
//}
//static void AddMovie() {
//    MyConsole.PrintLine("\nAdd movie:");
//    string title = MyConsole.PromptString("Enter movie title: ");
//    string director = MyConsole.PromptString("Enter director: ");
//    int year = MyConsole.PromptInt("Enter release year: ");
//    Movie newMovie = new Movie(title,director,year);
//    movies.Add(newMovie);
//    MyConsole.PrintLine("Movie added successfully!~");
//}

//static void ListMovies() {
//    MyConsole.PrintLine("\nList of Movies:");
//    if (movies.Count==0) {
//        MyConsole.PrintLine("No movies available");
//    }
//    else {
//        foreach (Movie movie in movies) {
//            MyConsole.PrintLine(movie);
//        }
//    }
//}
