using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static double Default(this IGuard _, double input)
    {
        return Guard.Against.Default(input, null, null);
    }

    public static double Default(this IGuard _, double input, string paramName)
    {
        return Guard.Against.Default(input, paramName, null);
    }

    public static double Default(this IGuard _, double input, string paramName, string message)
    {
        return Guard.Against.Default<double>(input, paramName, message);
    }
}