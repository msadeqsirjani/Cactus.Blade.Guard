using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static decimal PositiveOrZero(this IGuard _, decimal input)
    {
        return Guard.MustBe.PositiveOrZero(input, null, null);
    }

    public static decimal PositiveOrZero(this IGuard _, decimal input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero(input, paramName, null);
    }

    public static decimal PositiveOrZero(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<decimal>(input, paramName, message);
    }
}