using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Default(this IGuard _, short input)
    {
        return Guard.MustBe.Default(input, null, null);
    }

    public static IGuard Default(this IGuard _, short input, string paramName)
    {
        return Guard.MustBe.Default(input, paramName, null);
    }

    public static IGuard Default(this IGuard _, short input, string paramName, string message)
    {
        return Guard.MustBe.Default<short>(input, paramName, message);
    }
}