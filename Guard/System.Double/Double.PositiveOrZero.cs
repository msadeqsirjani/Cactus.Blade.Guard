using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static double PositiveOrZero(this IGuard _, double input)
    {
        return Guard.MustBe.PositiveOrZero(input, null, null);
    }

    public static double PositiveOrZero(this IGuard _, double input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero(input, paramName, null);
    }

    public static double PositiveOrZero(this IGuard _, double input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<double>(input, paramName, message);
    }
}