using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Negative(this IGuard _, short input)
    {
        return Guard.MustBe.Negative<short>(input);
    }

    public static IGuard Negative(this IGuard _, short input, string paramName)
    {
        return Guard.MustBe.Default<short>(input, paramName);
    }

    public static IGuard Negative(this IGuard _, short input, string paramName, string message)
    {
        return Guard.MustBe.Negative<short>(input, paramName, message);
    }
}