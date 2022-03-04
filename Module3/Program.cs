using Module3;

if (args.Length < 1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Not enough arguments.");
    return;
}

var programs = Helper.Programs();
var name = args[0].ToLower();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Looking for \"{name}\" in {programs.Length} program(s).");

foreach (var program in programs)
{
    if (!program.Name().ToLower().Contains(name)) continue;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Found and running {program.Name()}...");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"About: {program.Description()}\n");
    Console.ResetColor();
    // Run the actual program.
    program.Run(args.Skip(1).ToArray());
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nProgram {program.Name()} ended successfully.");
    return;
}

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Program {name} doesn't exist.");