using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static float Default(this IGuard _, float input)
    {
        return Guard.Against.Default(input, null, null);
    }

    public static float Default(this IGuard _, float input, string paramName)
    {
        return Guard.Against.Default(input, paramName, null);
    }

    public static float Default(this IGuard _, float input, string paramName, string message)
    {
        return Guard.Against.Default<float>(input, paramName, message);
    }
}