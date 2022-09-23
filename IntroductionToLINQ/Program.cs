using IntroductionToLINQ.Data;

int[] numbers = new int[] { 1, 35, 7, 43, 2, 4, 25, 7, 89, 4, 2, 7 };

IEnumerable<int> query = numbers.Where(IsItEven);

IEnumerable<Car> cars = Car.GetCars();

IEnumerable<int> nums = Enumerable.Range(1, 6);
string batmanIntro = Enumerable.Repeat("na", 16) + "BATMAN";

foreach (int item in query) {
    Console.WriteLine($"\tthe foreach got {item}");
}

query = numbers.Where(input => input > 10);
foreach (int item in query) {
    Console.WriteLine($"\tthe foreach got {item}");
}

var query2 = numbers
    .Where(input => input > 10)
    .OrderBy(input => input)
    .Select(input => new { SixDigitCode = input.ToString("d6"), Original = input });

foreach (var item in query2) {
    Console.WriteLine(item);
}

bool IsItEven(int input) {
    bool result = input % 2 == 0;
    Console.WriteLine(
        $"the IsItEven has been called with {input} and it is going to return {result}");
    return result;
}

//Min
cars.FirstOrDefault(c => c.Price == cars.Min(c => c.Price));
//Max
//Average
int howManyNumbersAreEven = numbers.Count(IsItEven);
//Aggregate
//MinBy
cars.MinBy(c => c.Price);
//MaxBy
//Lab: AggregateOperators

numbers.Any(IsItEven);
numbers.Any();
numbers.All(IsItEven);
//Lab: Quantifiers

//First
int theFirstNumberGreaterThan20 = numbers.First(n => n > 20);
theFirstNumberGreaterThan20 = numbers.FirstOrDefault(n => n > 20);

Car? car = cars.FirstOrDefault(c => c.Brand == "Lamborghini");
Console.WriteLine(car?.Model);
//Last
//Single
//ElementAt
//Lab: ElementOperations

//Distinct
//Union
//Intercept
//Except
//Lab: SetOperations



//Concat
//SequenceEquals
//Zip
IEnumerable<(Car Car, int Id)> q = cars.Zip(nums);
//Lab: SequenceOperations

//ToArray
//ToList
//ToDictionary


//OfType
List<Person> people = new() {
    new Driver() { Name = "Mario Andretti" },
    new Supplier() { Name = "Supplying Company" },
    new Musician() { Name = "Plini" },
    new Customer() { Name = "Alice Anderson" },
    new Musician() { Name = "John Petrucci" },
    new Musician() { Name = "Mike Portnoy" },
    new Person() { Name = "Super Mario" }
};

//Lab: ConversionOperators

//Take
//Skip
//Lab: Partitioning


