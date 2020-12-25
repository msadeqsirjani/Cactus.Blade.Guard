using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Max(decimal input, decimal minimum)
    {
        return Guard.MustBe.Max(input, minimum);
    }

    public static IGuard Max(decimal input, decimal minimum, string paramName)
    {
        return Guard.MustBe.Max(input, minimum, paramName);
    }

    public static IGuard Max(decimal input, decimal minimum, string paramName, string message)
    {
        return Guard.MustBe.Max(input, minimum, paramName, message);
    }
}