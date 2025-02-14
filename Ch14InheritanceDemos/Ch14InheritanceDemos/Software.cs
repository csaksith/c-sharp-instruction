using System.Reflection.Metadata.Ecma335;

namespace Ch14InheritanceDemos {
    // Software is inheriting from Product
    internal class Software:Product {
    public string Version { get; set; }
        
        public Software(string code, string description, decimal price, string version):
            base(code, description,price) {
            this.Version = version;
        }

    }
}
