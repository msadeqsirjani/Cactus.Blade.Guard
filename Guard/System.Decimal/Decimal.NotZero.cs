using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static decimal NotZero(this IGuard _, decimal input)
    {
        return Guard.Against.NotZero(input, null, null);
    }

    public static decimal NotZero(this IGuard _, decimal input, string paramName)
    {
        return Guard.Against.NotZero(input, paramName, null);
    }


    public static decimal NotZero(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.Against.NotZero<decimal>(input, paramName, message);
    }
}