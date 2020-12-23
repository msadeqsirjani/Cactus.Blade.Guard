using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static ulong Negative(this IGuard _, ulong input)
    {
        return Guard.Against.Negative(input, null, null);
    }

    public static ulong Negative(this IGuard _, ulong input, string paramName)
    {
        return Guard.Against.Negative(input, paramName, null);
    }

    public static ulong Negative(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.Against.Negative<ulong>(input, paramName, message);
    }
}