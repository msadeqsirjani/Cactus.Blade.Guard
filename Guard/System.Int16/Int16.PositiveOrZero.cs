using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static short PositiveOrZero(this IGuard _, short input)
    {
        return Guard.MustBe.PositiveOrZero(input, null, null);
    }

    public static short PositiveOrZero(this IGuard _, short input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero(input, paramName, null);
    }

    public static short PositiveOrZero(this IGuard _, short input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<short>(input, paramName, message);
    }
}