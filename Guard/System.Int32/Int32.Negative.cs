using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Negative(this IGuard _, int input)
    {
        return Guard.MustBe.Negative<int>(input);
    }

    public static IGuard Negative(this IGuard _, int input, string paramName)
    {
        return Guard.MustBe.Negative<int>(input, paramName);
    }

    public static IGuard Negative(this IGuard _, int input, string paramName, string message)
    {
        return Guard.MustBe.Negative<int>(input, paramName, message);
    }
}