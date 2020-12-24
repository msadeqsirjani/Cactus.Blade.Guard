using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static double NegativeOrZero(this IGuard _, double input)
    {
        return Guard.MustBe.NegativeOrZero(input, null, null);
    }

    public static double NegativeOrZero(this IGuard _, double input, string paramName)
    {
        return Guard.MustBe.NegativeOrZero(input, paramName, null);
    }

    public static double NegativeOrZero(this IGuard _, double input, string paramName, string message)
    {
        return Guard.MustBe.NegativeOrZero<double>(input, paramName, message);
    }
}