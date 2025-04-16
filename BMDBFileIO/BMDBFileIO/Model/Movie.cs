namespace BMDBFileIO {
    // creating Movie class to add properties and methods
    public class Movie {
        // properties
        public int ID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Rating { get; set; }
        public string Director { get; set; }

        // constructor that accepts above
        // create an instance
        // setting property values
        public Movie(int id,string title,int year,string rating,string director) {
            this.ID=id;
            this.Title=title;
            this.Year=year;
            this.Rating=rating;
            this.Director=director;
        }
        // tostring method to display movie details
        public override string ToString() {
            return $"{ID}: {Title} ({Year}), Rating: {Rating}, Director: {Director}";
        }
    }

}
