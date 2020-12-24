using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static ulong Negative(this IGuard _, ulong input)
    {
        return Guard.MustBe.Negative(input, null, null);
    }

    public static ulong Negative(this IGuard _, ulong input, string paramName)
    {
        return Guard.MustBe.Negative(input, paramName, null);
    }

    public static ulong Negative(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.MustBe.Negative<ulong>(input, paramName, message);
    }
}