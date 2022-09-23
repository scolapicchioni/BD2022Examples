namespace IntroductionToLINQ.Data;

public class Supplier : Person {
    public int Id { get; set; }
    public string City { get; set; }
    public override string ToString() => $"{Id} - {Name} - {City}";

    public static List<Supplier> GetSuppliers() => new() {
            new () { Id=1, Name="Dallas Cowboys", City="Dallas" },
            new () { Id=2, Name="Dallas Movers", City="Dallas" },
            new () { Id=3, Name="Torino Traslochi", City="Torino" },
            new () { Id=4, Name="Seattle FastMovers", City="Seattle" }
        };
}
