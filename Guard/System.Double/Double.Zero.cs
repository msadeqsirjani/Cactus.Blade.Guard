using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static double Zero(this IGuard _, double input)
    {
        return Guard.MustBe.Zero(input, null, null);
    }

    public static double Zero(this IGuard _, double input, string paramName)
    {
        return Guard.MustBe.Zero(input, paramName, null);
    }


    public static double Zero(this IGuard _, double input, string paramName, string message)
    {
        return Guard.MustBe.Zero<double>(input, paramName, message);
    }
}