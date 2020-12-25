using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, int input)
    {
        return Guard.MustBe.NotDefault<int>(input);
    }

    public static IGuard NotDefault(this IGuard _, int input, string paramName)
    {
        return Guard.MustBe.NotDefault<int>(input, paramName);
    }

    public static IGuard NotDefault(this IGuard _, int input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<int>(input, paramName, message);
    }
}