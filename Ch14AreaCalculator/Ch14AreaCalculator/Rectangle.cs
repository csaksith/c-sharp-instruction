namespace Ch14AreaCalculator {
    public class Rectangle : Shape {
        public double height;
        public double width;
        // constructor to initialize the width and height
      
        public Rectangle(double width, double height) : base(width) {
            this.height = height;
        }
       
        // setter
        public double GetHeight() {
            return height;
        }
        public double GetWidth() {
            return width;
        }

        public override double GetArea() {
            return height*width;
        }

    }
}
