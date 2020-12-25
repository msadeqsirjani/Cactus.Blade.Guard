using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard PositiveOrZero(this IGuard _, double input)
    {
        return Guard.MustBe.PositiveOrZero<double>(input);
    }

    public static IGuard PositiveOrZero(this IGuard _, double input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero<double>(input, paramName);
    }

    public static IGuard PositiveOrZero(this IGuard _, double input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<double>(input, paramName, message);
    }
}