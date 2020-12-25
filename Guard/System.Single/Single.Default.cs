using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Default(this IGuard _, float input)
    {
        return Guard.MustBe.Default<float>(input);
    }

    public static IGuard Default(this IGuard _, float input, string paramName)
    {
        return Guard.MustBe.Default<float>(input, paramName);
    }

    public static IGuard Default(this IGuard _, float input, string paramName, string message)
    {
        return Guard.MustBe.Default<float>(input, paramName, message);
    }
}