using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static ulong Default(this IGuard _, ulong input)
    {
        return Guard.Against.Default(input, null, null);
    }

    public static ulong Default(this IGuard _, ulong input, string paramName)
    {
        return Guard.Against.Default(input, paramName, null);
    }

    public static ulong Default(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.Against.Default<ulong>(input, paramName, message);
    }
}