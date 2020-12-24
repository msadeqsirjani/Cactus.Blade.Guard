using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static double Default(this IGuard _, double input)
    {
        return Guard.MustBe.Default(input, null, null);
    }

    public static double Default(this IGuard _, double input, string paramName)
    {
        return Guard.MustBe.Default(input, paramName, null);
    }

    public static double Default(this IGuard _, double input, string paramName, string message)
    {
        return Guard.MustBe.Default<double>(input, paramName, message);
    }
}