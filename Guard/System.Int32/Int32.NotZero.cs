using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static int NotZero(this IGuard _, int input)
    {
        return Guard.Against.NotZero(input, null, null);
    }

    public static int NotZero(this IGuard _, int input, string paramName)
    {
        return Guard.Against.NotZero(input, paramName, null);
    }


    public static int NotZero(this IGuard _, int input, string paramName, string message)
    {
        return Guard.Against.NotZero<int>(input, paramName, message);
    }
}