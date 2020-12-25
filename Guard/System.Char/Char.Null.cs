using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Null(char? input)
    {
        return Guard.MustBe.Null(input, null, null);
    }

    public static IGuard Null(char? input, string paramName)
    {
        return Guard.MustBe.Null(input, paramName, null);
    }

    public static IGuard Null(char? input, string paramName, string message)
    {
        return Guard.MustBe.Null(input, paramName, message);
    }
}