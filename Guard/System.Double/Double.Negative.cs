using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static double Negative(this IGuard _, double input)
    {
        return Guard.Against.Negative(input, null, null);
    }

    public static double Negative(this IGuard _, double input, string paramName)
    {
        return Guard.Against.Negative(input, paramName, null);
    }

    public static double Negative(this IGuard _, double input, string paramName, string message)
    {
        return Guard.Against.Negative<double>(input, paramName, message);
    }
}