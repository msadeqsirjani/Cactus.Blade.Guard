using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, short input)
    {
        return Guard.MustBe.NotDefault<double>(input);
    }

    public static IGuard NotDefault(this IGuard _, short input, string paramName)
    {
        return Guard.MustBe.NotDefault<double>(input, paramName);
    }

    public static IGuard NotDefault(this IGuard _, short input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<short>(input, paramName, message);
    }
}