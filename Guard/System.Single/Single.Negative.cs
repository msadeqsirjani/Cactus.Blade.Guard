using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static float Negative(this IGuard _, float input)
    {
        return Guard.Against.Negative(input, null, null);
    }

    public static float Negative(this IGuard _, float input, string paramName)
    {
        return Guard.Against.Negative(input, paramName, null);
    }

    public static float Negative(this IGuard _, float input, string paramName, string message)
    {
        return Guard.Against.Negative<float>(input, paramName, message);
    }
}