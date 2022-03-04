namespace Module3;

public static class Helper
{
    public static IAssignment[] Programs()
    {
        IAssignment[] programs =
        {
            new Variables.Program(),
            new Returns.Program(),
            new ReadLine.Program(),
            new Arguments.Program(),
            new IfElse.Program()
        };
        return programs;
    }
}