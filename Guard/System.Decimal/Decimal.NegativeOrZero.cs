using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NegativeOrZero(this IGuard _, decimal input)
    {
        return Guard.MustBe.NegativeOrZero<decimal>(input);
    }

    public static IGuard NegativeOrZero(this IGuard _, decimal input, string paramName)
    {
        return Guard.MustBe.NegativeOrZero<decimal>(input, paramName);
    }

    public static IGuard NegativeOrZero(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.MustBe.NegativeOrZero<decimal>(input, paramName, message);
    }
}