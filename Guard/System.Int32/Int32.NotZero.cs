using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static int NotZero(this IGuard _, int input)
    {
        return Guard.MustBe.NotZero(input, null, null);
    }

    public static int NotZero(this IGuard _, int input, string paramName)
    {
        return Guard.MustBe.NotZero(input, paramName, null);
    }


    public static int NotZero(this IGuard _, int input, string paramName, string message)
    {
        return Guard.MustBe.NotZero<int>(input, paramName, message);
    }
}