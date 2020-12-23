using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static long NegativeOrZero(this IGuard _, long input)
    {
        return Guard.Against.NegativeOrZero(input, null, null);
    }

    public static long NegativeOrZero(this IGuard _, long input, string paramName)
    {
        return Guard.Against.NegativeOrZero(input, paramName, null);
    }

    public static long NegativeOrZero(this IGuard _, long input, string paramName, string message)
    {
        return Guard.Against.NegativeOrZero<long>(input, paramName, message);
    }
}