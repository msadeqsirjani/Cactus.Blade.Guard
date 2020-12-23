using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static ulong NegativeOrZero(this IGuard _, ulong input)
    {
        return Guard.Against.NegativeOrZero(input, null, null);
    }

    public static ulong NegativeOrZero(this IGuard _, ulong input, string paramName)
    {
        return Guard.Against.NegativeOrZero(input, paramName, null);
    }

    public static ulong NegativeOrZero(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.Against.NegativeOrZero<ulong>(input, paramName, message);
    }
}