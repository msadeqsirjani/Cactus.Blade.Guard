using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static long NotDefault(this IGuard _, long input)
    {
        return Guard.MustBe.NotDefault(input, null, null);
    }

    public static long NotDefault(this IGuard _, long input, string paramName)
    {
        return Guard.MustBe.NotDefault(input, paramName, null);
    }

    public static long NotDefault(this IGuard _, long input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<long>(input, paramName, message);
    }
}