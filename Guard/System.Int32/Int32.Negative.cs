using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static int Negative(this IGuard _, int input)
    {
        return Guard.Against.Negative(input, null, null);
    }

    public static int Negative(this IGuard _, int input, string paramName)
    {
        return Guard.Against.Negative(input, paramName, null);
    }

    public static int Negative(this IGuard _, int input, string paramName, string message)
    {
        return Guard.Against.Negative<int>(input, paramName, message);
    }
}