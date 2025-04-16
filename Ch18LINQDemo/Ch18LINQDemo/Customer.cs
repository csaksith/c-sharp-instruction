namespace Ch18LINQDemo;

public class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; } = "";
    public override string ToString() {
        return $"Customer: ({CustomerID})|{Name}";
    }
}
