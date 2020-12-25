using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Negative(this IGuard _, ulong input)
    {
        return Guard.MustBe.Negative<ulong>(input);
    }

    public static IGuard Negative(this IGuard _, ulong input, string paramName)
    {
        return Guard.MustBe.Negative<ulong>(input, paramName);
    }

    public static IGuard Negative(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.MustBe.Negative<ulong>(input, paramName, message);
    }
}