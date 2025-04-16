using System.Collections.Generic;
using System.IO;

namespace BMDBFileIO {
    // Declare properties
    internal class MovieDB {
        private const string Dir = @"C:\C#\Files\";
        private const string Path = Dir+"Movies.txt";
        private const string Sep = "|";

        // Write out all the products in that list to the file
        public static List<Movie> GetMovies() {
            using StreamReader reader = new(new FileStream(Path,FileMode.Open,FileAccess.Read));
            List<Movie> movies = new List<Movie>();
            while (reader.Peek()!=-1) {
                string row = reader.ReadLine();
                string[] cols = row.Split(Sep);
                if (cols.Length==5) {
                    int id = int.Parse(cols[0]);
                    string title = cols[1];
                    int year = int.Parse(cols[2]);
                    string rating = cols[3];
                    string director = cols[4];

                    // Create new instance of Movie
                    Movie m = new Movie(id,title,year,rating,director);
                    movies.Add(m);
                }
            }
            return movies;
        }

        // Method to save movies to the file
        public static void SaveMovies(List<Movie> movies) {
            using StreamWriter writer = new StreamWriter(new FileStream(Path,FileMode.Create,FileAccess.Write));
            foreach (Movie m in movies) {
                writer.Write(m.ID+Sep);
                writer.Write(m.Title+Sep);
                writer.Write(m.Year+Sep);
                writer.Write(m.Rating+Sep);
                writer.WriteLine(m.Director);
            }
        }
    }
}