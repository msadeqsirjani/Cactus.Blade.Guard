using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static byte Positive(this IGuard _, byte input)
    {
        return Guard.Against.Positive(input, null, null);
    }

    public static byte Positive(this IGuard _, byte input, string paramName)
    {
        return Guard.Against.Positive(input, paramName, null);
    }

    public static byte Positive(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.Against.Positive<byte>(input, paramName, message);
    }
}