using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static int NegativeOrZero(this IGuard _, int input)
    {
        return Guard.Against.NegativeOrZero(input, null, null);
    }

    public static int NegativeOrZero(this IGuard _, int input, string paramName)
    {
        return Guard.Against.NegativeOrZero(input, paramName, null);
    }

    public static int NegativeOrZero(this IGuard _, int input, string paramName, string message)
    {
        return Guard.Against.NegativeOrZero<int>(input, paramName, message);
    }
}