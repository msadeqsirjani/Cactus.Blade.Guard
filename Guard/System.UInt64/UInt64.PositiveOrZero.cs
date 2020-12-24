using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static ulong PositiveOrZero(this IGuard _, ulong input)
    {
        return Guard.MustBe.PositiveOrZero(input, null, null);
    }

    public static ulong PositiveOrZero(this IGuard _, ulong input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero(input, paramName, null);
    }

    public static ulong PositiveOrZero(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<ulong>(input, paramName, message);
    }
}