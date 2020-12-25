using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Null(ulong? input)
    {
        return Guard.MustBe.Null(input, null, null);
    }

    public static IGuard Null(ulong? input, string paramName)
    {
        return Guard.MustBe.Null(input, paramName, null);
    }

    public static IGuard Null(ulong? input, string paramName, string message)
    {
        return Guard.MustBe.Null(input, paramName, message);
    }
}