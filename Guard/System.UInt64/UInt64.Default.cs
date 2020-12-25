using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Default(this IGuard _, ulong input)
    {
        return Guard.MustBe.Default<ulong>(input);
    }

    public static IGuard Default(this IGuard _, ulong input, string paramName)
    {
        return Guard.MustBe.Default<ulong>(input, paramName);
    }

    public static IGuard Default(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.MustBe.Default<ulong>(input, paramName, message);
    }
}