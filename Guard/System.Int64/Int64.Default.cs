using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Default(this IGuard _, long input)
    {
        return Guard.MustBe.Default<long>(input);
    }

    public static IGuard Default(this IGuard _, long input, string paramName)
    {
        return Guard.MustBe.Default<long>(input, paramName);
    }

    public static IGuard Default(this IGuard _, long input, string paramName, string message)
    {
        return Guard.MustBe.Default<long>(input, paramName, message);
    }
}