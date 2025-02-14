namespace Ch15InterfaceDemo
{
    internal class Product : Summarizable, IComparable<Product>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(string code, string description, decimal price)
        {
            this.Code = code;
            this.Price = price;
            this.Description = description;
        }

        public string GetSummaryDetails()
        {
            string summary = $"Product: ({Code}) {Description} @ {Price:c}";
            return summary;
        }
        public int CompareTo(Product other)
        {
            // Example: Sort by Price
            return this.Price.CompareTo(other.Price);
        }

      
    }
}
