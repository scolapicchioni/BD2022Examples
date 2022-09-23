

ArrayList<int> list = new ArrayList<int>();

list.Add(5);
//list.Add("HI");
//list.Add(new Car());
//list.Add(new BankAccount());

int o = list.ItemAt(2);

ArrayList<Car> list2 = new ArrayList<Car>();
Car c = list2.ItemAt(0);
Console.WriteLine(c.Price);

ListOfCars listOfCars = new();
listOfCars.Add(new Car());
c = listOfCars.ItemAt(2);
//c.Price

List <Car> cars = new List<Car>() { 
    new Car(){ Id = 1, Brand = "FIAT", Name = "Punto", Price = 23_000 },
    new Car(){ Id = 2, Brand = "FIAT", Name = "500", Price = 13_000 },
    new Car(){ Id = 3, Brand = "FERRARI", Name = "F1", Price = 1_123_000 },
    new Car(){ Id = 4, Brand = "FERRARI", Name = "Enzo", Price = 2_223_000 },
    new Car(){ Id = 5, Brand = "Alfa Romeo", Name = "MiTo", Price = 33_000 },
    new Car(){ Id = 6, Brand = "Alfa Romeo", Name = "Giulietta", Price = 27_000 }
};

dynamic myVariable = new { Bla = 3, Hirfg = "fhruew" };
//object myVariable = new { Bla = 3, Hirfg = "fhruew" };
Console.WriteLine(myVariable.Bla);

myVariable = 1234;


IEnumerable<CarWithBTW> query2 = cars.ProjectTo(TransformCarToCarWithBTW);

foreach (CarWithBTW carWithBTW in query2) {
    //carWithBTW.PriceWithBTW
}

IEnumerable<Car> query = cars.Filter(c => c.Price > 300_000).Filter(c=>c.Brand == "FIAT");

cars.Add(new Car() { Price = 2000_000 });

foreach (var item in query) {

}

IEnumerable<int> query3 = cars.ProjectTo(c => c.Id);
IEnumerable<string> query4 = cars.ProjectTo(c => c.Name);
var query5 = cars.ProjectTo(c => new { FullName = $"{c.Name} {c.Brand}", c.Price });

foreach (var item in query5) {
    //item.FullName
}



List<Car> fiats = FilterCars_WhereBrandIsFiat(cars);
PrintCars("FIAT", fiats);

fiats = FilterCars_Where(cars, IsBrandFIAT);


List<Car> prices = Filter(cars, IsPriceLessThan100_000);

List<string> names = new List<string>() { "Mike", "Paul", "Frank", "Denny", "Martha", "Monique", "Marco" };

//List<string> namesStartingWithM = MyMethods.Filter(names, (name) => name.StartsWith("M"));
IEnumerable<string> namesStartingWithM = names.Filter((name) => name.StartsWith("M"));
//List<Car> prices = cars.FilterCars_Where(IsPriceLessThan100_000)
//                       .OrderBy()
//                       .GroupBy();

PrintCars("LESS THAN 100_000", prices);

prices = FilterCars_Where(cars, c =>c.Name.StartsWith("A") /*DoesNameStartWithA*/);
PrintCars("LESS THAN 100_000", prices);

prices = FilterCars_Where(cars, c => c.Id < 2 );

//sharplab.io
System.Action action = () => System.Console.WriteLine("HI");

//Operation executeOperation = Subtract;

//int result = executeOperation(5, 3);

//executeOperation = Add;

//result = executeOperation(5, 3);

int Add(int a, int b) {
    return a + b;
}

int Subtract(int a, int b) {
    return a - b;
}

int Multiply(int a, int b) {
    return a * b;
}

int Divide(int a, int b) {
    return a / b;
}

bool IsPriceLessThan100_000(Car car) {
    return car.Price < 100_000;
}

bool IsBrandFIAT(Car car) {
    return car.Brand == "FIAT";
}

bool DoesNameStartWithA(Car c) {
    return c.Name.StartsWith("A");
}
Operation? SelectOperation() {
    Operation operation;
    Console.WriteLine("Operation?");
    string input = Console.ReadLine();
    switch (input) {
        case "1":
            operation = Add;
            break;
        case "2":
            operation = Subtract;
            break;
        case "3":
            operation = Multiply;
            break;
        case "4":
            operation = Divide;
            break;
        case "5":
            operation = (a, b) => {
                return a + b;
            };
            break;
        default:
            return null;
    }
    return null;
}

void AskAndExecute(Operation execute) {
    Console.Write("First operand: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.Write("Second operand: ");
    int n2 = int.Parse(Console.ReadLine());
    int result = execute(n1, n2);
    Console.WriteLine($"The result is {result}");
}

List<TheTypeToFilter> Filter<TheTypeToFilter>(List<TheTypeToFilter> original, Checker<TheTypeToFilter> CheckCar) {
    List<TheTypeToFilter> result = new List<TheTypeToFilter>();
    foreach (TheTypeToFilter car in original) {
        if (CheckCar(car)) {
            result.Add(car);
        }
    }
    return result;
}


List<Car> FilterCars_Where(List<Car> original, CarChecker CheckCar) {
    List<Car> result = new List<Car>();
    foreach (Car car in original) {
        if (CheckCar(car)) {
            result.Add(car);
        }
    }
    return result;
}

List<BankAccount> FilterBankAccounts_Where(List<BankAccount> original, BankAccountChecker CheckBankAccount) {
    List<BankAccount> result = new List<BankAccount>();
    foreach (BankAccount car in original) {
        if (CheckBankAccount(car)) {
            result.Add(car);
        }
    }
    return result;
}

List<Car> FilterCars_WhereBrandIsFiat(List<Car> original) {
    List<Car> result = new List<Car>();
    foreach (Car car in original) {
        if (car.Brand == "FIAT") {
            result.Add(car);
        }
    }
    return result;
}

void PrintCars(string message, List<Car> cars) {
    Console.WriteLine($"*******{message}******");
    foreach (var item in cars) {
        Console.WriteLine(item);
    }
}

CarWithBTW TransformCarToCarWithBTW(Car input) {
    return new CarWithBTW() { FullName = input.Brand + " " + input.Name, PriceWithBTW = input.Price * 1.2M };
}

dynamic TransformCarToAnonimousType(Car input) {
    return new { Stuff = input.Name  };
}

class CarWithBTW {
    public decimal PriceWithBTW { get; set; }
    public string FullName { get; set; }
}



delegate int Operation(int firstOperand, int secondOperand);

delegate bool CarChecker(Car carToCheck);
delegate bool BankAccountChecker(BankAccount bankAccountToCheck);

delegate bool Checker<TheTypeToCheck>(TheTypeToCheck bankAccountToCheck);


//static void EnumerableExamples() {
//    string s = "abcdefghuijkreghjrkehref0";

//    CharEnumerator enumerator = s.GetEnumerator();

//    while (enumerator.MoveNext()) {
//        Console.WriteLine(enumerator.Current);
//    }

//    int[] numbers = new int[] { 5, 7, 3, 2, 5, 7, 9, 9, 54, 3, 0 };

//    System.Collections.IEnumerator arrayEnumerator = numbers.GetEnumerator();

//    while (arrayEnumerator.MoveNext()) {
//        int item = (int)arrayEnumerator.Current;
//        Console.WriteLine(item);
//    }

//    foreach (int item in numbers) {
//        Console.WriteLine(item);
//    }
//}

