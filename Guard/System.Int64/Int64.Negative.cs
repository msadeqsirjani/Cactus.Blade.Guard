using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Negative(this IGuard _, long input)
    {
        return Guard.MustBe.Negative(input, null, null);
    }

    public static IGuard Negative(this IGuard _, long input, string paramName)
    {
        return Guard.MustBe.Negative(input, paramName, null);
    }

    public static IGuard Negative(this IGuard _, long input, string paramName, string message)
    {
        return Guard.MustBe.Negative<long>(input, paramName, message);
    }
}