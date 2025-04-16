
namespace Ch14AreaCalculator {
    // circle class inherits from shape and implements the req methods and properties
    // add constructor to intialize the radius and methods 
    public class Circle : Shape {
        public double radius;
        // constructor to initialize the radius
        public Circle(double radius) {
            this.radius=radius;
        }
        // getter for radius 
        public double GetRadius() {
            return radius;
        }
        // setter for radius
        public void SetRadius(double radius) {
            this.radius=radius;
        }
        public override double GetArea() {
            // area = pi*radius^2
            return Math.PI*radius*radius;
        }
    }
}
