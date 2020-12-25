using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Positive(this IGuard _, long input)
    {
        return Guard.MustBe.Positive<long>(input);
    }

    public static IGuard Positive(this IGuard _, long input, string paramName)
    {
        return Guard.MustBe.Positive<long>(input, paramName);
    }

    public static IGuard Positive(this IGuard _, long input, string paramName, string message)
    {
        return Guard.MustBe.Positive<long>(input, paramName, message);
    }
}