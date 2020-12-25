using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Positive(this IGuard _, float input)
    {
        return Guard.MustBe.Positive<float>(input);
    }

    public static IGuard Positive(this IGuard _, float input, string paramName)
    {
        return Guard.MustBe.Positive<float>(input, paramName);
    }

    public static IGuard Positive(this IGuard _, float input, string paramName, string message)
    {
        return Guard.MustBe.Positive<float>(input, paramName, message);
    }
}