using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NegativeOrZero(this IGuard _, byte input)
    {
        return Guard.MustBe.NegativeOrZero<byte>(input);
    }

    public static IGuard NegativeOrZero(this IGuard _, byte input, string paramName)
    {
        return Guard.MustBe.NegativeOrZero<byte>(input, paramName);
    }

    public static IGuard NegativeOrZero(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.MustBe.NegativeOrZero<byte>(input, paramName, message);
    }
}