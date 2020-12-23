using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static float NegativeOrZero(this IGuard _, float input)
    {
        return Guard.Against.NegativeOrZero(input, null, null);
    }

    public static float NegativeOrZero(this IGuard _, float input, string paramName)
    {
        return Guard.Against.NegativeOrZero(input, paramName, null);
    }

    public static float NegativeOrZero(this IGuard _, float input, string paramName, string message)
    {
        return Guard.Against.NegativeOrZero<float>(input, paramName, message);
    }
}