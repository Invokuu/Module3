namespace Module3.Variables;

public class Program : IAssignment
{
    public string Name() => "Variables";

    public string Description() => "Variables assignment 1 and 2";

    public void Run(string[] args)
    {
        // Not using var throughout this to show the types

        Console.WriteLine("--- Task 1 ---");
        int intNumber = 298348934;
        Console.WriteLine($"int: {intNumber}");
        long longNumber = 2349825983458923498;
        Console.WriteLine($"long: {longNumber}");
        float floatNumber = 345.45F;
        Console.WriteLine($"float: {floatNumber}");
        decimal decimalNumber = 9024563.896456456M;
        Console.WriteLine($"decimal: {decimalNumber}");
        double doubleNumber = 90234.585;
        Console.WriteLine($"double: {doubleNumber}");
        string textString = "This is a string of text!";
        Console.WriteLine($"string: {textString}");
        char character = 'X';
        Console.WriteLine($"char: {character}");
        bool trueOrFalse = true;
        Console.WriteLine($"bool: {trueOrFalse}");

        Console.WriteLine("--- Task 2 ---");
        int a = 5;
        decimal b = 3.0M;
        decimal sum = a + b;
        Console.WriteLine($"The type of sum has to be decimal: {a}+{b}={sum}");
    }
}