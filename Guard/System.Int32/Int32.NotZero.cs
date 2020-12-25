using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotZero(this IGuard _, int input)
    {
        return Guard.MustBe.NotZero<int>(input);
    }

    public static IGuard NotZero(this IGuard _, int input, string paramName)
    {
        return Guard.MustBe.NotZero<int>(input, paramName);
    }


    public static IGuard NotZero(this IGuard _, int input, string paramName, string message)
    {
        return Guard.MustBe.NotZero<int>(input, paramName, message);
    }
}