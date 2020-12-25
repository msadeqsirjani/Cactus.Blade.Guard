using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NegativeOrZero(this IGuard _, short input)
    {
        return Guard.MustBe.NegativeOrZero<double>(input);
    }

    public static IGuard NegativeOrZero(this IGuard _, short input, string paramName)
    {
        return Guard.MustBe.NegativeOrZero<short>(input, paramName);
    }

    public static IGuard NegativeOrZero(this IGuard _, short input, string paramName, string message)
    {
        return Guard.MustBe.NegativeOrZero<short>(input, paramName, message);
    }
}