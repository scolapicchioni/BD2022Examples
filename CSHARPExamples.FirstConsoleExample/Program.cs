// See https://aka.ms/new-console-template for more information

using System.Text;
using CSHARPExamples.FirstConsoleExample;
using ServiceA;
class Program 
{
    public static void Main() {
        
    }

    private static void Examples08() {
        MethodExamplesClass methodExamples = new MethodExamplesClass();
        Console.WriteLine("this is main");
        methodExamples.SomeMethodThatDoesStuff();
        Console.WriteLine("this is main");
        int resultOfThatMethod = methodExamples.SomeMethodThatReturnsStuff();
        Console.WriteLine(resultOfThatMethod);

        (int a, bool b, string c) = methodExamples.SomeMethodThatReturnsATuple();

        (int age, bool hasChildren, string name) oneResult = methodExamples.SomeMethodThatReturnsATuple();

        methodExamples.SomeMethodThatAcceptsAnInt(42);

        methodExamples.SomeMethodThatAcceptsAnIntAndAStringAndABoolean(42, "hi", true);
        //methodExamples.SomeMethodThatAcceptsAnIntAndAStringAndABoolean("hi", 42, true);

        methodExamples.SomeMethodThatAcceptsAnIntAndAStringAndABoolean(
            secondParameter: "hi",
            firstParameter: 42,
            thirdParameter: false);

        //methodExamples.SomeMethodThatAcceptsOptionalParameters(,, false);
        methodExamples.SomeMethodThatAcceptsOptionalParameters(42);
        methodExamples.SomeMethodThatAcceptsOptionalParameters(42, "hi!");
        methodExamples.SomeMethodThatAcceptsOptionalParameters(42, "hi", true);
        methodExamples.SomeMethodThatAcceptsOptionalParameters(thirdParameter: true);

        int argument; //= 5;
        //Console.WriteLine($"argument is now {argument}");
        //methodExamples.Increment(argument);
        //Console.WriteLine($"argument is now {argument}");

        //methodExamples.IncrementByRef(ref argument);
        methodExamples.WriteOnOutArgument(out argument);
        Console.WriteLine(argument);

        int result; //= int.Parse("fghdjukg");

        bool gelukt = int.TryParse("0", out result);

        Console.WriteLine("the tryparse has now " + result);

        methodExamples.SayHi();

        methodExamples.SayHi("Simona");

        methodExamples.SayHi(10);

        //methodExamples.SomePrivateMethod();
    }

    private static void Example07() {
        MyClass my = new MyClass();
        my.MyMethod(42);


        bool inputIsOk = false;
        while (!inputIsOk) {
            try {
                Console.Write("age? ");
                string userInput = Console.ReadLine();
                int age = int.Parse(userInput);
                inputIsOk = true;
                if (age > 18) {
                    Console.WriteLine("You my enter");
                } else {
                    Console.WriteLine("You shall not pass!");
                }

            } catch (FormatException theProblem) {
                Console.WriteLine($"Please enter a number, will ya? {theProblem.Message}");
            } catch (OverflowException) {
                Console.WriteLine("ok. retry with something else.");
            } catch (Exception ex) {
                Console.WriteLine($"BOOOOOOOOO {ex.GetType().Name} {ex.Message}!");
            } finally {

            }
        }
    }

    private static void Example06() {
        Console.WriteLine("name?");
        string userName = Console.ReadLine();
        //if (else)
        if (userName.Length > 10) {
            Console.WriteLine("you have a long name!");
        } else if (userName.Length > 5) {
            Console.WriteLine("medium name");
        } else {
            Console.WriteLine("short name");
        }

        int x = 18;

        //switch
        switch (x) {
            case 0:

            case 1:
                Console.WriteLine("...");
                break;
            case 3:
                Console.WriteLine("!!!");
                break;
            default:
                break;
        }

        x = 1;
        //while
        while (x < 10) {
            Console.WriteLine(x);
            x++;
        }


        //do while
        do {

        } while (x < 10);

        //for
        //for (int i = 0; i < length; i++) {

        //}


        //foreach
        foreach (char letter in "simona colapicchioni")
            Console.WriteLine(letter);
        Console.WriteLine("HI");
    }

    private static void Example05() {
        /*
         * 5.	Now create two accounts in the main method, 
         * one with a Checkings type and  one with a Savings type.
         */

        BankAccount checkingsAccount;
        checkingsAccount.Balance = 0;
        checkingsAccount.AccountType = AccountType.Checkings;

        BankAccount savingsAccount;
        savingsAccount.Balance = 0;
        savingsAccount.AccountType = AccountType.Savings;

        /* 6.	Let the user input the account number in the console window 
        for the new accounts by using the Console.ReadLine method. */
        Console.Write("Please, insert the account number for the Checkings Account: ");
        checkingsAccount.AccountNumber = Console.ReadLine();

        Console.Write("Please, insert the account number for the Savings Account: ");
        savingsAccount.AccountNumber = Console.ReadLine();
        // 7.	Use string interpolation to print the field values of the two accounts

        Console.WriteLine($"The {checkingsAccount.AccountType} has an Id of {checkingsAccount.AccountNumber} and a balance of {checkingsAccount.Balance}");
        Console.WriteLine($"The {savingsAccount.AccountType} has an Id of {savingsAccount.AccountNumber} and a balance of {savingsAccount.Balance}");


        //int age = int.Parse(Console.ReadLine());
        //age.ToString()

        long resultOfMyFirstLibrary = long.MaxValue;

        int inputOfTheSecondLibrary = (int)resultOfMyFirstLibrary;

        string s = "5";
        //inputOfTheSecondLibrary = (int)s;

        resultOfMyFirstLibrary = inputOfTheSecondLibrary;

        (double price, string name, bool inStock) myProduct = (price: 123, name: "Dell stuff", inStock: true);

    }
}


