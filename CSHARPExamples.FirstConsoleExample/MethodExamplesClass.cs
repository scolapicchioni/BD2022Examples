namespace CSHARPExamples.FirstConsoleExample; 
internal class MethodExamplesClass 
{
    int someVariable;

    private int someValue;
    //public / private / protected / internal
    //default: private

    //static / (instance)

    //type of the output
    //void
    //int 
    //bool
    //string
    //(int, bool, string)
    //BankAccount
    //...

    //name of your method

    //(type nameOfParameter1, type nameOfParameter2)

    //block
    internal void SomeMethodThatDoesStuff() 
    {
        int someValue = 22;

        //this.someValue
        Console.WriteLine("This is SomeMethodThatDoesStuff");
    }

    internal int SomeMethodThatReturnsStuff() 
    {
        Console.WriteLine("This is SomeMethodThatReturnsStuff");
        return 42;
    }

    internal (int age, bool hasChildren, string name) SomeMethodThatReturnsATuple() {
        Console.WriteLine("This is SomeMethodThatReturnsATuple");
        return (42, true, "John");
    }

    internal void SomeMethodThatAcceptsAnInt(int firstParameter)
    {
        Console.WriteLine($"SomeMethodThatAcceptsAnInt got {firstParameter}");
    }

    internal void SomeMethodThatAcceptsAnIntAndAStringAndABoolean(int firstParameter, string secondParameter, bool thirdParameter) {
        Console.WriteLine($"SomeMethodThatAcceptsAnInt got {firstParameter} {secondParameter} {thirdParameter}");
    }

    internal void SomeMethodThatAcceptsOptionalParameters(int firstParameter = 100, string secondParameter = "", bool thirdParameter = false) {
        Console.WriteLine($"SomeMethodThatAcceptsAnInt got {firstParameter} {secondParameter} {thirdParameter}");
    }

    internal void Increment(int parameter) {
        Console.WriteLine($"parameter is {parameter}");
        parameter++;
        Console.WriteLine($"parameter is {parameter}");
    }

    internal void IncrementByRef(ref int parameter) {
        Console.WriteLine($"parameter is {parameter}");
        parameter++;
        Console.WriteLine($"parameter is {parameter}");
    }

    internal void WriteOnOutArgument(out int parameter) {
        //Console.WriteLine($"parameter is {parameter}");
        parameter = 42;
        Console.WriteLine($"parameter is {parameter}");
    }

    internal void SayHi() {
        SayHi(string.Empty, 1);
    }

    internal void SayHi(string name) {
        SayHi(name, 1);
    }

    internal void SayHi(string name, int times) {
        for (int i = 0; i < times; i++) {
            Console.WriteLine($"HI {name}!");
        }
    }

    internal void SayHi(int times) {
        SayHi(string.Empty, times);
        SomePrivateMethod();



    }



    private void SomePrivateMethod() 
    { 
        ///<summary>
        /// 
        ///</summary>
        void oneMethod() { 
        
        }

        oneMethod();
        //step 2
        oneMethod();
        //step 4
    }



    internal int sum(int a, int b) => a + b;

    //internal int Sum(int a, int b, int c) {
    //    return a + b + c;
    //}
    //Sum(4,2,7,4);
    //internal int Sum(int a, int b, int c, int d) {
    //    return a + b + c + d;
    //}

    //
    //Sum(4,2,7,4); 
    //int[] arguments = new int[4];
    //arguments[0] = 4;
    //arguments[1] = 2;
    //arguments[2] = 7;
    //arguments[3] = 4;
    //Sum(arguments);
    internal int Sum(params int[] parameters) {
        int result = 0;
        for (int i = 0; i < parameters.Length; i++) {
            result += parameters[i];
        }
        return result;
    }


}
