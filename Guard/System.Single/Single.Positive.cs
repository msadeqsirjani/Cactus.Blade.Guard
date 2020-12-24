using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static float Positive(this IGuard _, float input)
    {
        return Guard.MustBe.Positive(input, null, null);
    }

    public static float Positive(this IGuard _, float input, string paramName)
    {
        return Guard.MustBe.Positive(input, paramName, null);
    }

    public static float Positive(this IGuard _, float input, string paramName, string message)
    {
        return Guard.MustBe.Positive<float>(input, paramName, message);
    }
}