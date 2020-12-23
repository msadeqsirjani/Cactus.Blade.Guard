using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static long Default(this IGuard _, long input)
    {
        return Guard.Against.Default(input, null, null);
    }

    public static long Default(this IGuard _, long input, string paramName)
    {
        return Guard.Against.Default(input, paramName, null);
    }

    public static long Default(this IGuard _, long input, string paramName, string message)
    {
        return Guard.Against.Default<long>(input, paramName, message);
    }
}