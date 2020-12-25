using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, float input)
    {
        return Guard.MustBe.NotDefault<float>(input);
    }

    public static IGuard NotDefault(this IGuard _, float input, string paramName)
    {
        return Guard.MustBe.NotDefault<float>(input, paramName);
    }

    public static IGuard NotDefault(this IGuard _, float input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<float>(input, paramName, message);
    }
}