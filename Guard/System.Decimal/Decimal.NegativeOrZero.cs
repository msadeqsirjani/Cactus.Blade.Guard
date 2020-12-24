using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static decimal NegativeOrZero(this IGuard _, decimal input)
    {
        return Guard.MustBe.NegativeOrZero(input, null, null);
    }

    public static decimal NegativeOrZero(this IGuard _, decimal input, string paramName)
    {
        return Guard.MustBe.NegativeOrZero(input, paramName, null);
    }

    public static decimal NegativeOrZero(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.MustBe.NegativeOrZero<decimal>(input, paramName, message);
    }
}