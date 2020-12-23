using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static int Default(this IGuard _, int input)
    {
        return Guard.Against.Default(input, null, null);
    }

    public static int Default(this IGuard _, int input, string paramName)
    {
        return Guard.Against.Default(input, paramName, null);
    }

    public static int Default(this IGuard _, int input, string paramName, string message)
    {
        return Guard.Against.Default<int>(input, paramName, message);
    }
}