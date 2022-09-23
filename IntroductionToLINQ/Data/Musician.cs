namespace IntroductionToLINQ.Data;

public class Musician : Person {
    public string City { get; set; }
    public List<string> Instruments { get; set; }

    public override string ToString() => $"{Name} - {City}";
    public static List<Musician> GetBeatles() => new() {
        new Musician { Name = "Paul", City = "Liverpool", Instruments = new List<string> { "Bass", "Guitar", "Vocals" } },
        new Musician { Name = "John", City = "New York", Instruments = new List<string> { "Guitar", "Piano", "Vocals" } },
        new Musician { Name = "George", City = "Liverpool", Instruments = new List<string> { "Guitar", "Vocals" } },
        new Musician { Name = "Ringo", City = "Los Angeles", Instruments = new List<string> { "Drums", "Vocals" } }
    };

    public static List<Musician> GetNirvana() => new() {
        new() { Name = "Kurt Cobain", Instruments = new() { "Vocals", "Guitar" } },
        new() { Name = "Krist Novoselic", Instruments = new() { "Bass" } },
        new() { Name = "Dave Grohl", Instruments = new() { "Drums" } }
    };

    public static List<Musician> GetFooFighters() => new() {
        new() { Name = "Dave Grohl", Instruments = new() { "Drums", "Vocals", "Bass", "Guitar" } },
        new() { Name = "Nate Mendel", Instruments = new() { "Bass" } },
        new() { Name = "William Goldsmith", Instruments = new() { "Drums" } },
        new() { Name = "Pat Smear", Instruments = new() { "Guitar" } }
    };
}
