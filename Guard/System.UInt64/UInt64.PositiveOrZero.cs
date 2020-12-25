using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard PositiveOrZero(this IGuard _, ulong input)
    {
        return Guard.MustBe.PositiveOrZero<ulong>(input);
    }

    public static IGuard PositiveOrZero(this IGuard _, ulong input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero<ulong>(input, paramName);
    }

    public static IGuard PositiveOrZero(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<ulong>(input, paramName, message);
    }
}