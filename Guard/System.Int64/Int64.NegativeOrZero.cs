using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static long NegativeOrZero(this IGuard _, long input)
    {
        return Guard.MustBe.NegativeOrZero(input, null, null);
    }

    public static long NegativeOrZero(this IGuard _, long input, string paramName)
    {
        return Guard.MustBe.NegativeOrZero(input, paramName, null);
    }

    public static long NegativeOrZero(this IGuard _, long input, string paramName, string message)
    {
        return Guard.MustBe.NegativeOrZero<long>(input, paramName, message);
    }
}