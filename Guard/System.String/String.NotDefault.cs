using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static string NotDefault(this IGuard _, string input)
    {
        return Guard.MustBe.NotDefault(input, null, null);
    }

    public static string NotDefault(this IGuard _, string input, string paramName)
    {
        return Guard.MustBe.NotDefault(input, paramName, null);
    }

    public static string NotDefault(this IGuard _, string input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<string>(input, paramName, message);
    }
}