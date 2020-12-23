using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static long Zero(this IGuard _, long input)
    {
        return Guard.Against.Zero(input, null, null);
    }

    public static long Zero(this IGuard _, long input, string paramName)
    {
        return Guard.Against.Zero(input, paramName, null);
    }


    public static long Zero(this IGuard _, long input, string paramName, string message)
    {
        return Guard.Against.Zero<long>(input, paramName, message);
    }
}