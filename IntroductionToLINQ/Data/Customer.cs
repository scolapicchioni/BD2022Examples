namespace IntroductionToLINQ.Data;

public enum Countries { USA, Italy }
public class Customer : Person {
    public string City { get; set; }
    public Countries Country { get; set; }
    public Order[] Orders { get; set; }
    public override string ToString() => $"Name : {Name} - City: {City} - Country: {Country}";

    public static List<Customer> GetCustomers() => new() {
            new Customer() {
                Name = "Paolo", City = "Brescia", Country = Countries.Italy, Orders = new Order[] {
                    new () {Id=1, Quantity = 3, ProductId = 1, Shipped = false, Month="January" },
                    new () {Id=2, Quantity = 5, ProductId = 2, Shipped = true, Month="May" },
                }
            },
            new Customer() {
                Name = "Marco", City = "Torino", Country = Countries.Italy, Orders = new Order[] {
                    new () {Id=3, Quantity = 10, ProductId = 1, Shipped = false, Month="July" },
                    new () {Id=4, Quantity = 20, ProductId = 3, Shipped = true, Month="December" },
                }
            },
            new Customer() {
                Name = "James", City = "Dallas", Country = Countries.USA, Orders = new Order[] {
                    new () {Id=5, Quantity = 20, ProductId = 3, Shipped = true, Month="December" }
                }
            },
            new Customer() {
                Name = "Frank", City = "Seattle", Country = Countries.USA, Orders = new Order[] {
                    new () {Id=6, Quantity = 20, ProductId = 5, Shipped = false, Month="July" }
                }
            }
        };
}
