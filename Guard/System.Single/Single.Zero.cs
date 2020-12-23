using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static float Zero(this IGuard _, float input)
    {
        return Guard.Against.Zero(input, null, null);
    }

    public static float Zero(this IGuard _, float input, string paramName)
    {
        return Guard.Against.Zero(input, paramName, null);
    }


    public static float Zero(this IGuard _, float input, string paramName, string message)
    {
        return Guard.Against.Zero<float>(input, paramName, message);
    }
}