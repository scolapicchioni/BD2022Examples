using IntroductionToLINQ.Data;

LeftJoin();

void SetOperations() {
    int[] numbers = { 1, 2, 3, 4, 3 };
    //Distinct
    Console.WriteLine("DISTINCT");
    foreach (var item in numbers.Distinct()) {
        Console.WriteLine(item);
    }
    int[] numbers2 = { -1, 5, 6, 1, 3, 6 };
    //Union
    Console.WriteLine("UNION");
    foreach (int item in numbers.Union(numbers2)) {
        Console.WriteLine(item);
    }
    //Intersect
    Console.WriteLine("Intersect");
    foreach (int item in numbers.Intersect(numbers2)) {
        Console.WriteLine(item);
    }
    //Except
    Console.WriteLine("Except");
    foreach (int item in numbers.Except(numbers2)) {
        Console.WriteLine(item);
    }
    //Lab: SetOperations
}

void SequenceOperations() {
    int[] numbers = { 5, 6, 1, 3, 2 };
    int[] numbers2 = { 5, 6, 1, 3, 2 };
    int[] numbers3 = { 2, 3, 5, 6, 1 };
    string[] letters = { "a", "b", "c", "d", "e" };
    //Concat
    Console.WriteLine("Concat");
    foreach (int item in numbers.Concat(numbers2)) {
        Console.WriteLine(item);
    }
    //SequenceEquals
    Console.WriteLine(numbers.SequenceEqual(numbers2));
    Console.WriteLine(numbers.SequenceEqual(numbers3));
    //Zip
    var result = letters.Zip(numbers,numbers3);
    foreach (var item in result) {
        
    }
    //Lab: SequenceOperations
}

void ConversionOperators() {
    int[] numbers = { 1, 2, 3, 4, 5 };
    int[,] matrix = { 
        { 1, 2, 3 }, 
        { 4, 5, 6 }, 
        { 7, 8, 9 } 
    };

    //ToArray
    //ToList
    //ToDictionary
    List<Car> cars = Car.GetCars();
    //cars.FirstOrDefault(c=>c.Id == 2)
    
    //cars.ToDictionary(c=>c.Id)
    //Cast
    

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

    foreach (Musician musician in people.OfType<Musician>()) {
        Console.WriteLine(musician);
    }

}

void Comparison() {
    List<Car> cars = Car.GetCars();

    IEnumerable<Car> query = cars
                            .Where(c => c.Price > 20_000)
                            .OrderBy(c => c.Price);

    IEnumerable<Car> comprehension_syntax = (from c in cars
                                            where c.Price > 20_000
                                            orderby c.Price
                                            select c).Distinct();

    IEnumerable<decimal> q = from c in cars
                         where c.Price > 20_000
                         orderby c.Price
                         select c.Price;

    IEnumerable<(string, decimal)> q2 = from c in cars
                             where c.Price > 20_000
                             orderby c.Price
                             select (c.Model, c.Price);

    var q3 = from c in cars
             where c.Price > 20_000
             orderby c.Price
             select new { c.Price, c.Model };

    //Projections


}

void GroupBy() {
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Mabc", "Jay", "Tamara", "Tim", "Dante", "Martha", "Marco", "John", "James" };

    var q = from n in names
            group n by n.Substring(0,1);

    Console.WriteLine("group by initial");
    foreach (IGrouping<string, string> groep in q) {
        Console.WriteLine(groep.Key);
        foreach (string name in groep) {
            Console.WriteLine($"\t{name}");
        }
    }

    var q2 = from n in names
            group n by n.Length;

    Console.WriteLine("group by length");
    foreach (IGrouping<int, string> groep in q2) {
        Console.WriteLine(groep.Key);
        foreach (string name in groep) {
            Console.WriteLine($"\t{name}");
        }
    }

    var q3 = from n in names
             group n by new { Initial = n.Substring(0, 1), n.Length };

    Console.WriteLine("group by initial and length");
    foreach (var groep in q3) {
        Console.WriteLine($"Initial: {groep.Key.Initial} Length: {groep.Key.Length}");
        foreach (string name in groep) {
            Console.WriteLine($"\t{name}");
        }
    }

    var q4 = from n in names
             group new { Name = n.ToUpper(), n.Length} by new { Initial = n.Substring(0, 1), n.Length };

    
    Console.WriteLine("group object by initial and length");
    foreach (var groep in q4) {
        Console.WriteLine($"Initial: {groep.Key.Initial} Length: {groep.Key.Length}");
        foreach (var name in groep) {
            Console.WriteLine($"\t{name.Name} {name.Length}");
        }
    }
}

void GroupInto() {
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay", "Tamara", "Tim", "Dante", "Martha", "Marco", "Mitch", "Tod", "John", "James" };

    var q = from n in names
            group new { Name = n.ToUpper(), n.Length } by n.Substring(0, 1)
            into groupedNames
            select (Initial: groupedNames.Key, HowManyItems : groupedNames.Count(), Items: groupedNames);

    //var q1 = from n in names
    //         group new { Name = n.ToUpper(), n.Length } by n.Substring(0, 1);
    //var q2 = from n in q1
    //        select (Initial: n.Key, Items: n);

    foreach (var item in q) {
        Console.WriteLine(item.Initial);
        foreach (var name in item.Items) {
            Console.WriteLine($"\t{name.Name}, {name.Length}");
        }
    }
}

void Where() {
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay", "Tamara", "Tim", "Dante", "Martha", "Marco", "Mitch", "Tod", "John", "James" };

    var query = from n in names
                where n.StartsWith("T")
                select n;
}

void OrderBy() {
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay", "Tamara", "Tim", "Dante", "Martha", "Marco", "Mitch", "Tod", "John", "James" };

    var q = from n in names
            orderby n
            select n;

    var q2 = names.OrderBy(n => n);

    var q3 =    from n in names
                orderby n.Length, n.Substring(0,1) descending
                select n;
    var q4 = names.OrderBy(n => n.Length).ThenByDescending(n => n.Substring(0, 1));

}

void LetOperator() {
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay", "Tamara", "Tim", "Dante", "Martha", "Marco", "Mitch", "Tod", "John", "James" };

    var q1 = from n in names
             where (n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")).Length > 3
             select n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");

    var q2 = from n in names
             let novowel = n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")
             where novowel.Length > 3
             select novowel + " comes from " + n;

    var q3 = names
                .Select(n => new { n, novowel = n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "") })
                .Where(theObject => theObject.novowel.Length > 3)
                .Select(theobject => theobject.novowel + " comes from " + theobject.n);

}
//Projections
//Grouping
//GroupingInto
//Restrictions
//Ordering
//LetOperator

void Join() {
    List<Car> cars = Car.GetCars();

    List<Driver> drivers = Driver.GetDrivers();

    var q1 = from c in cars

             join d in drivers
             on c.Id equals d.CarId //inner equi join

             select new { c.Brand, c.Model, d.Name, d.Surname };

    foreach (var item in q1) {
        Console.WriteLine(item);
    }
}


void JoinInto() {
    List<Car> cars = Car.GetCars();

    List<Driver> drivers = Driver.GetDrivers();
    var q1 = from c in cars

             join d in drivers
             on c.Id equals d.CarId
             into cardrivers

             select new { c.Brand, c.Model, Drivers = cardrivers };

    Console.WriteLine("without default");
    foreach (var item in q1) {
        Console.WriteLine($"{item.Model} {item.Brand}");
        foreach (var d in item.Drivers) {
            Console.WriteLine(d);
        }
    }

    var q2 = from c in cars

             join d in drivers
             on c.Id equals d.CarId
             into cardrivers

             select new { c.Brand, c.Model, Drivers = cardrivers.DefaultIfEmpty(new Driver() { Name = "No DRIVER", Surname = "FOUND..." }) };

    Console.WriteLine("*************with default************");
    foreach (var item in q2) {
        Console.WriteLine($"{item.Model} {item.Brand}");
        foreach (var d in item.Drivers) {
            Console.WriteLine(d);
        }
    }
}

void JoinIntoAny() {
    List<Car> cars = Car.GetCars();

    List<Driver> drivers = Driver.GetDrivers();

    var q1 = from c in cars

                 //-------------------//
             join d in drivers
             on c.Id equals d.CarId
             into cardrivers         //new range variable

             where cardrivers.Any()
             //-------------------//
             select new { Car = c, Drivers = cardrivers };
    foreach (var item in q1) {
        
    }


}

void SelectMany() {
    List<Musician> beatles = Musician.GetBeatles();

    Console.WriteLine("ORIGINAL");
    foreach (var beatle in beatles) {
        Console.WriteLine(beatle.Name);
        foreach (var instrument in beatle.Instruments) {
            Console.WriteLine("\t" + instrument);
        }
    }

    var q1 = from musician in beatles
             from instrument in musician.Instruments

             select new { musician.Name, Instrument = instrument };

    Console.WriteLine("FLAT TABLE");
    foreach (var item in q1) {
        Console.WriteLine($"{item.Name} - {item.Instrument}");
    }

    string[] names = { "John Mark", "Frank Steve Fanny", "Phillis James Mary Dave" };
    //John
    //Mark
    //Frank
    //Steve

    Console.WriteLine("flat pivot");
    var q = from collectionOfNames in names
            from name in collectionOfNames.Split()
            select new { collectionOfNames, name };

    foreach (var item in q) {
        Console.WriteLine(item);
    }
}

void LeftJoin() {
    List<Car> cars = Car.GetCars();

    List<Driver> drivers = Driver.GetDrivers();

    var q1 = from c in cars

             join d in drivers
             on c.Id equals d.CarId
             into cardrivers

             from driverForCar in cardrivers.DefaultIfEmpty(new Driver() { Name = "", Surname = "", Id = 0 })

             select new { CarModel = c.Model, CarBrand = c.Brand, DriverName = driverForCar.Name, DriverSurname = driverForCar.Surname };

    foreach (var item in q1) {
        Console.WriteLine($"{item.CarBrand} {item.CarModel} {item.DriverName} {item.DriverSurname}");
    }
}
//JoinOperations
//LeftJoin
//MegaChallenge

static void Day01() {
    IEnumerable<Car> cars = Car.GetCars();

    IEnumerable<int> nums;
    int[] numbers = new int[] { 1, 35, 7, 43, 2, 4, 25, 7, 89, 4, 2, 7 };

    IEnumerable<int> query = numbers.Where(IsItEven);

    cars = Car.GetCars();
    nums = Enumerable.Range(1, 6);
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
}



