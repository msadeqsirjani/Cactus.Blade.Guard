using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, long input)
    {
        return Guard.MustBe.NotDefault<long>(input);
    }

    public static IGuard NotDefault(this IGuard _, long input, string paramName)
    {
        return Guard.MustBe.NotDefault<long>(input, paramName);
    }

    public static IGuard NotDefault(this IGuard _, long input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<long>(input, paramName, message);
    }
}