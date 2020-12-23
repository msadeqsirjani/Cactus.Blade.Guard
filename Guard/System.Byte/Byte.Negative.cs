using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static byte Negative(this IGuard _, byte input)
    {
        return Guard.Against.Negative(input, null, null);
    }

    public static byte Negative(this IGuard _, byte input, string paramName)
    {
        return Guard.Against.Negative(input, paramName, null);
    }

    public static byte Negative(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.Against.Negative<byte>(input, paramName, message);
    }
}