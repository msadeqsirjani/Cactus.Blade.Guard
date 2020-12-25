using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NegativeOrZero(this IGuard _, float input)
    {
        return Guard.MustBe.NegativeOrZero<float>(input);
    }

    public static IGuard NegativeOrZero(this IGuard _, float input, string paramName)
    {
        return Guard.MustBe.NegativeOrZero<float>(input, paramName);
    }

    public static IGuard NegativeOrZero(this IGuard _, float input, string paramName, string message)
    {
        return Guard.MustBe.NegativeOrZero<float>(input, paramName, message);
    }
}