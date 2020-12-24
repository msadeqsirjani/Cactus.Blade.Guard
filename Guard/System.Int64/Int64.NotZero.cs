using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static long NotZero(this IGuard _, long input)
    {
        return Guard.MustBe.NotZero(input, null, null);
    }

    public static long NotZero(this IGuard _, long input, string paramName)
    {
        return Guard.MustBe.NotZero(input, paramName, null);
    }


    public static long NotZero(this IGuard _, long input, string paramName, string message)
    {
        return Guard.MustBe.NotZero<long>(input, paramName, message);
    }
}