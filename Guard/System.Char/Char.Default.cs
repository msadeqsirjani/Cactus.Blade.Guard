using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Default(this IGuard _, char input)
    {
        return Guard.MustBe.Default<char>(input);
    }

    public static IGuard Default(this IGuard _, char input, string paramName)
    {
        return Guard.MustBe.Default<char>(input, paramName);
    }

    public static IGuard Default(this IGuard _, char input, string paramName, string message)
    {
        return Guard.MustBe.Default<char>(input, paramName, message);
    }
}