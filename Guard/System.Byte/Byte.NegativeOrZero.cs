using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static byte NegativeOrZero(this IGuard _, byte input)
    {
        return Guard.Against.NegativeOrZero(input, null, null);
    }

    public static byte NegativeOrZero(this IGuard _, byte input, string paramName)
    {
        return Guard.Against.NegativeOrZero(input, paramName, null);
    }

    public static byte NegativeOrZero(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.Against.NegativeOrZero<byte>(input, paramName, message);
    }
}