namespace IntroductionToLINQ.Data;

public class Category {
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString() => $"{Id} - {Name}";

    public static List<Category> GetCategories() => new () {
            new () { Id = 1, Name = "Pasta" },
            new () { Id = 2, Name = "Beverages"},
            new () { Id = 3, Name = "Other"}
        };
    
}
