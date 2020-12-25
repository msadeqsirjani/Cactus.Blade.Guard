using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NegativeOrZero(this IGuard _, ulong input)
    {
        return Guard.MustBe.NegativeOrZero<ulong>(input);
    }

    public static IGuard NegativeOrZero(this IGuard _, ulong input, string paramName)
    {
        return Guard.MustBe.NegativeOrZero<ulong>(input, paramName);
    }

    public static IGuard NegativeOrZero(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.MustBe.NegativeOrZero<ulong>(input, paramName, message);
    }
}