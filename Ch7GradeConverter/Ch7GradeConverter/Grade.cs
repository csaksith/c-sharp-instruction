
namespace Ch07GradeConverter {

    public class Grade {
        // Field to store numerical grade
        public int numGrade;
        // integer parameter constructor
        public Grade() {
            numGrade=0;
        }

        public Grade(int numGrade) {
            this.numGrade=numGrade;
        }

        // method to set the grade number
        public void SetNumber(int numGrade) {
            this.numGrade=numGrade;
        }

        public int GetNumber() {
            return numGrade;
        }

        // method to get the letter grade
        public string GetLetter() {
            string returnStr = "Letter Grade: ";

            if (numGrade>=88&&numGrade<=100) {
                returnStr+="A";
            }
            else if (numGrade>=80) {
                returnStr+="B";
            }
            else if (numGrade>=67) {
                returnStr+="C";
            }
            else if (numGrade>=60) {
                returnStr+="D";
            }
            else {
                returnStr+="F";
            }

            return returnStr;  //  Now it actually returns the string
        }
    }
}
