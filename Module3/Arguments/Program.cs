namespace Module3.Arguments;

public class Program : IAssignment
{
    public string Name() => "Arguments";

    public string Description() => "Testing program arguments, assignment 1 and 2";

    public void Run(string[] args)
    {
        Console.WriteLine("--- Task 1 ---");
        Console.WriteLine($"Arguments: {string.Join(", ", args)}");

        Console.WriteLine("--- Task 2 ---");
        Console.WriteLine($"Argument count: {args.Length}");
    }
}