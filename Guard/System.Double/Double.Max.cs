using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Min(double input, double minimum)
    {
        return Guard.MustBe.Min(input, minimum);
    }

    public static IGuard Min(double input, double minimum, string paramName)
    {
        return Guard.MustBe.Min(input, minimum, paramName);
    }

    public static IGuard Min(double input, double minimum, string paramName, string message)
    {
        return Guard.MustBe.Min(input, minimum, paramName, message);
    }
}