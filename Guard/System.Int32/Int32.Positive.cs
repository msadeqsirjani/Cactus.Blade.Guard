using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Positive(this IGuard _, int input)
    {
        return Guard.MustBe.Positive<int>(input);
    }

    public static IGuard Positive(this IGuard _, int input, string paramName)
    {
        return Guard.MustBe.Positive<int>(input, paramName);
    }

    public static IGuard Positive(this IGuard _, int input, string paramName, string message)
    {
        return Guard.MustBe.Positive<int>(input, paramName, message);
    }
}