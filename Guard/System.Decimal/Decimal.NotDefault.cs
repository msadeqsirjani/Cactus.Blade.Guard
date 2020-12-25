using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, decimal input)
    {
        return Guard.MustBe.NotDefault<decimal>(input);
    }

    public static IGuard NotDefault(this IGuard _, decimal input, string paramName)
    {
        return Guard.MustBe.NotDefault<decimal>(input, paramName);
    }

    public static IGuard NotDefault(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<decimal>(input, paramName, message);
    }
}