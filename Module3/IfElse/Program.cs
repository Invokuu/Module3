namespace Module3.IfElse;

public class Program : IAssignment
{
    public string Name() => "IfElse";

    public string Description() => "Using if and else, assigment 1, 2 and 3";

    public void Run(string[] args)
    {
        Console.WriteLine("--- Task 1 ---");
        Console.WriteLine($"Is integers equal? {this.IsEqualInteger(3, 5)}");

        Console.WriteLine("--- Task 2 ---");
        Console.WriteLine($"Multiply if equal: {this.MultiplyIfEqual(5, 5)}");

        Console.WriteLine("--- Task 3 ---");
        Console.WriteLine($"Is either integer or sum 30? {this.IsEitherOrSum30(10, 20)}");
    }

    private bool IsEqualInteger(int a, int b)
    {
        // Shorthand: return a == b;
        if (a == b)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private int MultiplyIfEqual(int a, int b)
    {
        // Shorthand: return a == b ? a * b : a + b;
        if (a == b)
        {
            return a * b;
        }
        else
        {
            return a + b;
        }
    }

    private bool IsEitherOrSum30(int a, int b)
    {
        // Shorthand: return a == 30 || b == 30 || a + b == 30;
        if (a == 30)
        {
            return true;
        }
        else if (b == 30)
        {
            return true;
        }
        else if (a + b == 30)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}