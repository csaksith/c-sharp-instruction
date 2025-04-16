namespace Ch14AreaCalculator {
    public class Square : Shape {
        public double width;

        // constructor to initialize the width
        public Square(double width) {
            this.width=width;
        }
        // getter for width
        public double GetWidth() {
            return width;
        }
        // setter for width
        public void SetWidth(double width) {
            this.width=width;
        }
        // implement abstract method to calc area
        public override double GetArea() {
            return width*width; 
        }
    }
}
