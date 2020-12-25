using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Default(this IGuard _, string input)
    {
        return Guard.MustBe.Default<string>(input);
    }

    public static IGuard Default(this IGuard _, string input, string paramName)
    {
        return Guard.MustBe.Default<string>(input, paramName);
    }

    public static IGuard Default(this IGuard _, string input, string paramName, string message)
    {
        return Guard.MustBe.Default<string>(input, paramName, message);
    }
}