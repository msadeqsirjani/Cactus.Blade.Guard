using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, double input)
    {
        return Guard.MustBe.NotDefault<double>(input);
    }

    public static IGuard NotDefault(this IGuard _, double input, string paramName)
    {
        return Guard.MustBe.NotDefault<double>(input, paramName);
    }

    public static IGuard NotDefault(this IGuard _, double input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<double>(input, paramName, message);
    }
}