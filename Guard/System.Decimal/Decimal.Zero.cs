using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static decimal Zero(this IGuard _, decimal input)
    {
        return Guard.Against.Zero(input, null, null);
    }

    public static decimal Zero(this IGuard _, decimal input, string paramName)
    {
        return Guard.Against.Zero(input, paramName, null);
    }


    public static decimal Zero(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.Against.Zero<decimal>(input, paramName, message);
    }
}