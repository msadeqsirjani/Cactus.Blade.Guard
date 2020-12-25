using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, ulong input)
    {
        return Guard.MustBe.NotDefault(input, null, null);
    }

    public static IGuard NotDefault(this IGuard _, ulong input, string paramName)
    {
        return Guard.MustBe.NotDefault(input, paramName, null);
    }

    public static IGuard NotDefault(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<ulong>(input, paramName, message);
    }
}