using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static float PositiveOrZero(this IGuard _, float input)
    {
        return Guard.MustBe.PositiveOrZero(input, null, null);
    }

    public static float PositiveOrZero(this IGuard _, float input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero(input, paramName, null);
    }

    public static float PositiveOrZero(this IGuard _, float input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<float>(input, paramName, message);
    }
}