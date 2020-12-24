using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static byte PositiveOrZero(this IGuard _, byte input)
    {
        return Guard.MustBe.PositiveOrZero(input, null, null);
    }

    public static byte PositiveOrZero(this IGuard _, byte input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero(input, paramName, null);
    }

    public static byte PositiveOrZero(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<byte>(input, paramName, message);
    }
}