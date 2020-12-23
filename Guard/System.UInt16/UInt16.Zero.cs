using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static ushort Zero(this IGuard _, ushort input)
    {
        return Guard.Against.Zero(input, null, null);
    }

    public static ushort Zero(this IGuard _, ushort input, string paramName)
    {
        return Guard.Against.Zero(input, paramName, null);
    }


    public static ushort Zero(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.Against.Zero<ushort>(input, paramName, message);
    }
}