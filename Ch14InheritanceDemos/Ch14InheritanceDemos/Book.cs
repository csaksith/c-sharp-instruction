using ConsoleLibrary;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;

namespace Ch14InheritanceDemos {
    internal class Book : Product {
        public string Author { get; set; }
        // pg 465
        // constructor
        public Book(string code,string description,decimal price,string author) :
            base(code,description,price) {
            this.Author=author;
        }
        public override string GetDisplayText(string sep) {
            return $"base.GetDisplayText(sep)({Author})";
        }
        

    }
}
