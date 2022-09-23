namespace IntroductionToLINQ.Data;

public class Driver : Person {
    public int Id { get; set; }
    public string Surname { get; set; }
    public int CarId { get; set; }
    public override string ToString() => $"{Id} - {Name} {Surname}";
    public static List<Driver> GetDrivers() => new() {
        new () { Id = 1, Name = "Alice", Surname = "Anderson", CarId = 5 },
        new () { Id = 2, Name = "Bob", Surname = "Builders", CarId = 2 },
        new () { Id = 3, Name = "Candice", Surname = "Clarkson", CarId = 9 },
        new () { Id = 4, Name = "Marco", Surname = "Danielson", CarId = 4 },
        new () { Id = 5, Name = "Giulia", Surname = "Conte", CarId = 4 },
        new () { Id = 6, Name = "Frank", Surname = "Funnel", CarId = 2 },
        new () { Id = 7, Name = "Donald", Surname = "Trump", CarId = 2 },
        new () { Id = 8, Name = "Stan", Surname = "Lee", CarId = 5 },
        new () { Id = 9, Name = "Kyle", Surname = "Korelson", CarId = 4 }
    };
}
