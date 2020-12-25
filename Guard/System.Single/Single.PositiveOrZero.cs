using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard PositiveOrZero(this IGuard _, float input)
    {
        return Guard.MustBe.PositiveOrZero<float>(input);
    }

    public static IGuard PositiveOrZero(this IGuard _, float input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero<float>(input, paramName);
    }

    public static IGuard PositiveOrZero(this IGuard _, float input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<float>(input, paramName, message);
    }
}