using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static long Negative(this IGuard _, long input)
    {
        return Guard.Against.Negative(input, null, null);
    }

    public static long Negative(this IGuard _, long input, string paramName)
    {
        return Guard.Against.Negative(input, paramName, null);
    }

    public static long Negative(this IGuard _, long input, string paramName, string message)
    {
        return Guard.Against.Negative<long>(input, paramName, message);
    }
}