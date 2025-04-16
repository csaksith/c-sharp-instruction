namespace Ch14AreaCalculator {
    public abstract  class Shape {
        // abstract method that must be implemented by derived class
        public abstract double GetArea();
        // default method to return a string representation of the shape
        // string override to display info       
        public override string ToString() {
            return $"Area: {GetArea()}";
        }

    }

}
