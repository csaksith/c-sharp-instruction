
using ConsoleLibrary;

namespace Ch14InheritanceDemos {
    public class Product {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


        public Product() {  }
        // empty constructor
        public Product(string Code,string Description,decimal Price) {
            this.Code=Code;
            this.Description=Description;
            this.Price=Price;
        }
        // virtual means it can be overrided later
        public virtual string GetDisplayText(string sep) {
            return $"{Code}{sep}{Price:c}{sep}{Description}";
        }
    }
}
