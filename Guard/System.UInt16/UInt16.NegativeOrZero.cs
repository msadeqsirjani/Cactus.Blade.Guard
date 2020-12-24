using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static ushort NegativeOrZero(this IGuard _, ushort input)
    {
        return Guard.MustBe.NegativeOrZero(input, null, null);
    }

    public static ushort NegativeOrZero(this IGuard _, ushort input, string paramName)
    {
        return Guard.MustBe.NegativeOrZero(input, paramName, null);
    }

    public static ushort NegativeOrZero(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.MustBe.NegativeOrZero<ushort>(input, paramName, message);
    }
}