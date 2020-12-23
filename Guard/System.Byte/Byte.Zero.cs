using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static byte Zero(this IGuard _, byte input)
    {
        return Guard.Against.Zero(input, null, null);
    }

    public static byte Zero(this IGuard _, byte input, string paramName)
    {
        return Guard.Against.Zero(input, paramName, null);
    }


    public static byte Zero(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.Against.Zero<byte>(input, paramName, message);
    }
}