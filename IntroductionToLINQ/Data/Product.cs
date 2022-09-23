namespace IntroductionToLINQ.Data;

public class Product {
    public int Id { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }

    public override string ToString() => $"ProductId: {Id} - Price: {Price} - CategoryId: {CategoryId}";
    public static List<Product> GetProducts() => new() {
            new () { Id=1, Price=10, CategoryId = 1},
            new () { Id=2, Price=20, CategoryId = 1},
            new () { Id=3, Price=30, CategoryId = 2},
            new () { Id=4, Price=40, CategoryId = 2},
            new () { Id=5, Price=50, CategoryId = 2},
            new () { Id=6, Price=60, CategoryId = 2}
        };
}
