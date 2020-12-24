using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static ushort PositiveOrZero(this IGuard _, ushort input)
    {
        return Guard.MustBe.PositiveOrZero(input, null, null);
    }

    public static ushort PositiveOrZero(this IGuard _, ushort input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero(input, paramName, null);
    }

    public static ushort PositiveOrZero(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<ushort>(input, paramName, message);
    }
}