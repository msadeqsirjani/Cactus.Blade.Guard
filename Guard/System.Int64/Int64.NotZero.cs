using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotZero(this IGuard _, long input)
    {
        return Guard.MustBe.NotZero<long>(input);
    }

    public static IGuard NotZero(this IGuard _, long input, string paramName)
    {
        return Guard.MustBe.NotZero<long>(input, paramName);
    }


    public static IGuard NotZero(this IGuard _, long input, string paramName, string message)
    {
        return Guard.MustBe.NotZero<long>(input, paramName, message);
    }
}