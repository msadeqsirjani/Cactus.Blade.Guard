using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static ushort NegativeOrZero(this IGuard _, ushort input)
    {
        return Guard.Against.NegativeOrZero(input, null, null);
    }

    public static ushort NegativeOrZero(this IGuard _, ushort input, string paramName)
    {
        return Guard.Against.NegativeOrZero(input, paramName, null);
    }

    public static ushort NegativeOrZero(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.Against.NegativeOrZero<ushort>(input, paramName, message);
    }
}