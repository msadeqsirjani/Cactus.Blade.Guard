using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NegativeOrZero(this IGuard _, long input)
    {
        return Guard.MustBe.NegativeOrZero<long>(input);
    }

    public static IGuard NegativeOrZero(this IGuard _, long input, string paramName)
    {
        return Guard.MustBe.NegativeOrZero<long>(input, paramName);
    }

    public static IGuard NegativeOrZero(this IGuard _, long input, string paramName, string message)
    {
        return Guard.MustBe.NegativeOrZero<long>(input, paramName, message);
    }
}