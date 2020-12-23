using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static double NotZero(this IGuard _, double input)
    {
        return Guard.Against.NotZero(input, null, null);
    }

    public static double NotZero(this IGuard _, double input, string paramName)
    {
        return Guard.Against.NotZero(input, paramName, null);
    }


    public static double NotZero(this IGuard _, double input, string paramName, string message)
    {
        return Guard.Against.NotZero<double>(input, paramName, message);
    }
}