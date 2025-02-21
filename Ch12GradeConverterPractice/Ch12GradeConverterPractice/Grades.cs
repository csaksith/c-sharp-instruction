
namespace Ch12GradeConverterPractice {
    internal class Grades {
        // initialize numGrade variable 
        public int numGrade { get; set; }
        // constructor for Grades
        public Grades(int numGrade) {
            this.numGrade=numGrade;
        }
        // constructor to convert numGrade to letterGrade
        // must have return variable
        public string GradeConverter() {
            string letterGrade = "F";
            // if statements for grades
            if (numGrade>=88) {
                letterGrade="A";
            }
            else if (numGrade>=80) {
                letterGrade="B";
            }
            else if (numGrade>=68) {
                letterGrade="C";
            }
            else if (numGrade>=60) {
                letterGrade="D";
            }
                return letterGrade;
        }

    }
}
