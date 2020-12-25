using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NegativeOrZero(this IGuard _, int input)
    {
        return Guard.MustBe.NegativeOrZero<int>(input);
    }

    public static IGuard NegativeOrZero(this IGuard _, int input, string paramName)
    {
        return Guard.MustBe.NegativeOrZero<int>(input, paramName);
    }

    public static IGuard NegativeOrZero(this IGuard _, int input, string paramName, string message)
    {
        return Guard.MustBe.NegativeOrZero<int>(input, paramName, message);
    }
}