using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Default(this IGuard _, long input)
    {
        return Guard.MustBe.Default(input, null, null);
    }

    public static IGuard Default(this IGuard _, long input, string paramName)
    {
        return Guard.MustBe.Default(input, paramName, null);
    }

    public static IGuard Default(this IGuard _, long input, string paramName, string message)
    {
        return Guard.MustBe.Default<long>(input, paramName, message);
    }
}