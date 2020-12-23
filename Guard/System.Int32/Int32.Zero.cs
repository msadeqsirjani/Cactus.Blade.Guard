using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static int Zero(this IGuard _, int input)
    {
        return Guard.Against.Zero(input, null, null);
    }

    public static int Zero(this IGuard _, int input, string paramName)
    {
        return Guard.Against.Zero(input, paramName, null);
    }


    public static int Zero(this IGuard _, int input, string paramName, string message)
    {
        return Guard.Against.Zero<int>(input, paramName, message);
    }
}