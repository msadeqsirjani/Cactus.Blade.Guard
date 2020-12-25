using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, char input)
    {
        return Guard.MustBe.NotDefault<char>(input);
    }

    public static IGuard NotDefault(this IGuard _, char input, string paramName)
    {
        return Guard.MustBe.NotDefault<char>(input, paramName);
    }

    public static IGuard NotDefault(this IGuard _, char input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<char>(input, paramName, message);
    }
}