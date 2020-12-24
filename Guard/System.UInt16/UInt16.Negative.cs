using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static ushort Negative(this IGuard _, ushort input)
    {
        return Guard.MustBe.Negative(input, null, null);
    }

    public static ushort Negative(this IGuard _, ushort input, string paramName)
    {
        return Guard.MustBe.Negative(input, paramName, null);
    }

    public static ushort Negative(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.MustBe.Negative<ushort>(input, paramName, message);
    }
}