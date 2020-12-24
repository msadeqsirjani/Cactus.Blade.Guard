using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static string Default(this IGuard _, string input)
    {
        return Guard.MustBe.Default(input, null, null);
    }

    public static string Default(this IGuard _, string input, string paramName)
    {
        return Guard.MustBe.Default(input, paramName, null);
    }

    public static string Default(this IGuard _, string input, string paramName, string message)
    {
        return Guard.MustBe.Default<string>(input, paramName, message);
    }
}