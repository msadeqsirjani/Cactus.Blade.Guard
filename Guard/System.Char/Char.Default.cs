using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static char Default(this IGuard _, char input)
    {
        return Guard.Against.Default(input, null, null);
    }

    public static char Default(this IGuard _, char input, string paramName)
    {
        return Guard.Against.Default(input, paramName, null);
    }

    public static char Default(this IGuard _, char input, string paramName, string message)
    {
        return Guard.Against.Default<char>(input, paramName, message);
    }
}