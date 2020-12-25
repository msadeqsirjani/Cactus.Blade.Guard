using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Default(this IGuard _, int input)
    {
        return Guard.MustBe.Default<int>(input);
    }

    public static IGuard Default(this IGuard _, int input, string paramName)
    {
        return Guard.MustBe.Default<int>(input, paramName);
    }

    public static IGuard Default(this IGuard _, int input, string paramName, string message)
    {
        return Guard.MustBe.Default<int>(input, paramName, message);
    }
}