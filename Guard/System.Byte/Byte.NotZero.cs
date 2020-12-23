using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static byte NotZero(this IGuard _, byte input)
    {
        return Guard.Against.NotZero(input, null, null);
    }

    public static byte NotZero(this IGuard _, byte input, string paramName)
    {
        return Guard.Against.NotZero(input, paramName, null);
    }


    public static byte NotZero(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.Against.NotZero<byte>(input, paramName, message);
    }
}