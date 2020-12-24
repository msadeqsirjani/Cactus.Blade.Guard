using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static int PositiveOrZero(this IGuard _, int input)
    {
        return Guard.MustBe.PositiveOrZero(input, null, null);
    }

    public static int PositiveOrZero(this IGuard _, int input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero(input, paramName, null);
    }

    public static int PositiveOrZero(this IGuard _, int input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<int>(input, paramName, message);
    }
}