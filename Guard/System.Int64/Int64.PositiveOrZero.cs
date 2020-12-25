using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard PositiveOrZero(this IGuard _, long input)
    {
        return Guard.MustBe.PositiveOrZero<long>(input);
    }

    public static IGuard PositiveOrZero(this IGuard _, long input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero<long>(input, paramName);
    }

    public static IGuard PositiveOrZero(this IGuard _, long input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<long>(input, paramName, message);
    }
}