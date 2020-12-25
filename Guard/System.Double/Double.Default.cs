using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Default(this IGuard _, double input)
    {
        return Guard.MustBe.Default<double>(input);
    }

    public static IGuard Default(this IGuard _, double input, string paramName)
    {
        return Guard.MustBe.Default<double>(input, paramName);
    }

    public static IGuard Default(this IGuard _, double input, string paramName, string message)
    {
        return Guard.MustBe.Default<double>(input, paramName, message);
    }
}