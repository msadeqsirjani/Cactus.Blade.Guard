using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static long Positive(this IGuard _, long input)
    {
        return Guard.MustBe.Positive(input, null, null);
    }

    public static long Positive(this IGuard _, long input, string paramName)
    {
        return Guard.MustBe.Positive(input, paramName, null);
    }

    public static long Positive(this IGuard _, long input, string paramName, string message)
    {
        return Guard.MustBe.Positive<long>(input, paramName, message);
    }
}