using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Negative(this IGuard _, decimal input)
    {
        return Guard.MustBe.Negative<decimal>(input);
    }

    public static IGuard Negative(this IGuard _, decimal input, string paramName)
    {
        return Guard.MustBe.Negative<decimal>(input, paramName);
    }

    public static IGuard Negative(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.MustBe.Negative<decimal>(input, paramName, message);
    }
}