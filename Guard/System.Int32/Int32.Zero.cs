using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static int Zero(this IGuard _, int input)
    {
        return Guard.MustBe.Zero(input, null, null);
    }

    public static int Zero(this IGuard _, int input, string paramName)
    {
        return Guard.MustBe.Zero(input, paramName, null);
    }


    public static int Zero(this IGuard _, int input, string paramName, string message)
    {
        return Guard.MustBe.Zero<int>(input, paramName, message);
    }
}