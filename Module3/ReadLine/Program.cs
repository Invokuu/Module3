namespace Module3.ReadLine;

public class Program : IAssignment
{
    public string Name() => "ReadLine";

    public string Description() => "Testing ReadLine and WriteLine, assignment 1";

    public void Run(string[] args)
    {
        Console.WriteLine("--- Task 1 ---");
        Console.WriteLine("Hei, hva heter du?");
        var input = Console.ReadLine();
        Console.WriteLine($"Velkommen {input}!");
    }
}