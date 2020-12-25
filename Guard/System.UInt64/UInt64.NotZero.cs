using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotZero(this IGuard _, ulong input)
    {
        return Guard.MustBe.NotZero(input, null, null);
    }

    public static IGuard NotZero(this IGuard _, ulong input, string paramName)
    {
        return Guard.MustBe.NotZero(input, paramName, null);
    }


    public static IGuard NotZero(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.MustBe.NotZero<ulong>(input, paramName, message);
    }
}