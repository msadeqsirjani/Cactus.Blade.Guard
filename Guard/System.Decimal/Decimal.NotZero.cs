using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotZero(this IGuard _, decimal input)
    {
        return Guard.MustBe.NotZero<decimal>(input);
    }

    public static IGuard NotZero(this IGuard _, decimal input, string paramName)
    {
        return Guard.MustBe.NotZero<decimal>(input, paramName);
    }


    public static IGuard NotZero(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.MustBe.NotZero<decimal>(input, paramName, message);
    }
}