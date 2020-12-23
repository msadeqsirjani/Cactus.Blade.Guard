using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static ulong Zero(this IGuard _, ulong input)
    {
        return Guard.Against.Zero(input, null, null);
    }

    public static ulong Zero(this IGuard _, ulong input, string paramName)
    {
        return Guard.Against.Zero(input, paramName, null);
    }


    public static ulong Zero(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.Against.Zero<ulong>(input, paramName, message);
    }
}