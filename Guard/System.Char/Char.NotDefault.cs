using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static char NotDefault(this IGuard _, char input)
    {
        return Guard.MustBe.NotDefault(input, null, null);
    }

    public static char NotDefault(this IGuard _, char input, string paramName)
    {
        return Guard.MustBe.NotDefault(input, paramName, null);
    }

    public static char NotDefault(this IGuard _, char input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<char>(input, paramName, message);
    }
}