using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static byte Default(this IGuard _, byte input)
    {
        return Guard.Against.Default(input, null, null);
    }

    public static byte Default(this IGuard _, byte input, string paramName)
    {
        return Guard.Against.Default(input, paramName, null);
    }

    public static byte Default(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.Against.Default<byte>(input, paramName, message);
    }
}