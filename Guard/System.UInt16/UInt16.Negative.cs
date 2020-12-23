using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static ushort Negative(this IGuard _, ushort input)
    {
        return Guard.Against.Negative(input, null, null);
    }

    public static ushort Negative(this IGuard _, ushort input, string paramName)
    {
        return Guard.Against.Negative(input, paramName, null);
    }

    public static ushort Negative(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.Against.Negative<ushort>(input, paramName, message);
    }
}