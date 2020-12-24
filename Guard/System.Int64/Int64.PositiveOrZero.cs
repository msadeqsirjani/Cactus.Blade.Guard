using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static long PositiveOrZero(this IGuard _, long input)
    {
        return Guard.MustBe.PositiveOrZero(input, null, null);
    }

    public static long PositiveOrZero(this IGuard _, long input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero(input, paramName, null);
    }

    public static long PositiveOrZero(this IGuard _, long input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<long>(input, paramName, message);
    }
}