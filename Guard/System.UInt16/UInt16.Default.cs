using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static ushort Default(this IGuard _, ushort input)
    {
        return Guard.Against.Default(input, null, null);
    }

    public static ushort Default(this IGuard _, ushort input, string paramName)
    {
        return Guard.Against.Default(input, paramName, null);
    }

    public static ushort Default(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.Against.Default<ushort>(input, paramName, message);
    }
}