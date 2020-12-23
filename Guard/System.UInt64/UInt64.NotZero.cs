using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static ulong NotZero(this IGuard _, ulong input)
    {
        return Guard.Against.NotZero(input, null, null);
    }

    public static ulong NotZero(this IGuard _, ulong input, string paramName)
    {
        return Guard.Against.NotZero(input, paramName, null);
    }


    public static ulong NotZero(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.Against.NotZero<ulong>(input, paramName, message);
    }
}