using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Positive(this IGuard _, ulong input)
    {
        return Guard.MustBe.Positive<ulong>(input);
    }

    public static IGuard Positive(this IGuard _, ulong input, string paramName)
    {
        return Guard.MustBe.Positive<ulong>(input, paramName);
    }

    public static IGuard Positive(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.MustBe.Positive<ulong>(input, paramName, message);
    }
}