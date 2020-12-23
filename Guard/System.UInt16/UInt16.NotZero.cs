using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static ushort NotZero(this IGuard _, ushort input)
    {
        return Guard.Against.NotZero(input, null, null);
    }

    public static ushort NotZero(this IGuard _, ushort input, string paramName)
    {
        return Guard.Against.NotZero(input, paramName, null);
    }


    public static ushort NotZero(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.Against.NotZero<ushort>(input, paramName, message);
    }
}