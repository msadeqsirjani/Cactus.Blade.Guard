using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Default(this IGuard _, decimal input)
    {
        return Guard.MustBe.Default<decimal>(input);
    }

    public static IGuard Default(this IGuard _, decimal input, string paramName)
    {
        return Guard.MustBe.Default<decimal>(input, paramName);
    }

    public static IGuard Default(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.MustBe.Default<decimal>(input, paramName, message);
    }
}