using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard PositiveOrZero(this IGuard _, int input)
    {
        return Guard.MustBe.PositiveOrZero<int>(input);
    }

    public static IGuard PositiveOrZero(this IGuard _, int input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero<int>(input, paramName);
    }

    public static IGuard PositiveOrZero(this IGuard _, int input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<int>(input, paramName, message);
    }
}