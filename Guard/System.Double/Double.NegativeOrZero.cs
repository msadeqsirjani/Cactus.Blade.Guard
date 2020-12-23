using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static double NegativeOrZero(this IGuard _, double input)
    {
        return Guard.Against.NegativeOrZero(input, null, null);
    }

    public static double NegativeOrZero(this IGuard _, double input, string paramName)
    {
        return Guard.Against.NegativeOrZero(input, paramName, null);
    }

    public static double NegativeOrZero(this IGuard _, double input, string paramName, string message)
    {
        return Guard.Against.NegativeOrZero<double>(input, paramName, message);
    }
}