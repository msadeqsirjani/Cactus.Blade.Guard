using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static decimal Negative(this IGuard _, decimal input)
    {
        return Guard.Against.Negative(input, null, null);
    }

    public static decimal Negative(this IGuard _, decimal input, string paramName)
    {
        return Guard.Against.Negative(input, paramName, null);
    }

    public static decimal Negative(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.Against.Negative<decimal>(input, paramName, message);
    }
}