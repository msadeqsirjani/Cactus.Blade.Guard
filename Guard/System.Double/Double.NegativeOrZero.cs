using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NegativeOrZero(this IGuard _, double input)
    {
        return Guard.MustBe.NegativeOrZero<double>(input);
    }

    public static IGuard NegativeOrZero(this IGuard _, double input, string paramName)
    {
        return Guard.MustBe.NegativeOrZero<double>(input, paramName);
    }

    public static IGuard NegativeOrZero(this IGuard _, double input, string paramName, string message)
    {
        return Guard.MustBe.NegativeOrZero<double>(input, paramName, message);
    }
}