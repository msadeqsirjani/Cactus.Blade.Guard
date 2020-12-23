using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static decimal NegativeOrZero(this IGuard _, decimal input)
    {
        return Guard.Against.NegativeOrZero(input, null, null);
    }

    public static decimal NegativeOrZero(this IGuard _, decimal input, string paramName)
    {
        return Guard.Against.NegativeOrZero(input, paramName, null);
    }

    public static decimal NegativeOrZero(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.Against.NegativeOrZero<decimal>(input, paramName, message);
    }
}