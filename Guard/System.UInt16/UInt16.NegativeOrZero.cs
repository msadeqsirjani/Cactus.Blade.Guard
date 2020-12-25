using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NegativeOrZero(this IGuard _, ushort input)
    {
        return Guard.MustBe.NegativeOrZero<ushort>(input);
    }

    public static IGuard NegativeOrZero(this IGuard _, ushort input, string paramName)
    {
        return Guard.MustBe.NegativeOrZero<ushort>(input, paramName);
    }

    public static IGuard NegativeOrZero(this IGuard _, ushort input, string paramName, string message)
    {
        return Guard.MustBe.NegativeOrZero<ushort>(input, paramName, message);
    }
}