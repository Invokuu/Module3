namespace Module3.Returns;

public class Program : IAssignment
{
    public string Name() => "Returns";

    public string Description() => "Functions with return values, assignment 1 and 2";

    public void Run(string[] args)
    {
        Console.WriteLine("--- Task 1 ---");
        Console.WriteLine($"Sum function: {this.Sum(3, 5)}");

        Console.WriteLine("--- Task 2 ---");
        this.Nothing();
    }

    private int Sum(int a, int b)
    {
        return a + b;
    }

    private void Nothing()
    {
        Console.WriteLine("Denne metoden returnerer ingenting");
    }
}