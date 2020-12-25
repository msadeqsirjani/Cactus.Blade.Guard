using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Positive(this IGuard _, ulong input)
    {
        return Guard.MustBe.Positive(input, null, null);
    }

    public static IGuard Positive(this IGuard _, ulong input, string paramName)
    {
        return Guard.MustBe.Positive(input, paramName, null);
    }

    public static IGuard Positive(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.MustBe.Positive<ulong>(input, paramName, message);
    }
}