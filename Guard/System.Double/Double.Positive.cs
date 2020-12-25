using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Positive(this IGuard _, double input)
    {
        return Guard.MustBe.Positive<double>(input);
    }

    public static IGuard Positive(this IGuard _, double input, string paramName)
    {
        return Guard.MustBe.Positive<double>(input, paramName);
    }

    public static IGuard Positive(this IGuard _, double input, string paramName, string message)
    {
        return Guard.MustBe.Positive<double>(input, paramName, message);
    }
}