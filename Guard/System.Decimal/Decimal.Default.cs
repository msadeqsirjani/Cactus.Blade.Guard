using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static decimal Default(this IGuard _, decimal input)
    {
        return Guard.MustBe.Default(input, null, null);
    }

    public static decimal Default(this IGuard _, decimal input, string paramName)
    {
        return Guard.MustBe.Default(input, paramName, null);
    }

    public static decimal Default(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.MustBe.Default<decimal>(input, paramName, message);
    }
}