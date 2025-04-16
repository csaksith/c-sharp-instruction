namespace Ch17ProductManagerDemo1 {
    public class Product {
        // property to store the product Code, Description, and Price
        // property //
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        // constructor to initialize a new instance of the product class
        // parameter:
        // - code: unique identifier for the product
        // - description: brief description of the product
        // - price: price of the code property
        // assign the provided code to the product
        // constructor of a Product class when a new instance of the class is created which accepts all properties
        public Product(string code,string description,decimal price) {
            this.Code=code;
            this.Description=description;
            this.Price=price;
        }
        // tostring is way we render the state of instance
        public override string ToString() {
            return $"Product: ({Code}) - {Description} @ {Price:C}";
        }
    }
}
