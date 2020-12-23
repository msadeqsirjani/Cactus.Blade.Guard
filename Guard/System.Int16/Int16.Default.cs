using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static short Default(this IGuard _, short input)
    {
        return Guard.Against.Default(input, null, null);
    }

    public static short Default(this IGuard _, short input, string paramName)
    {
        return Guard.Against.Default(input, paramName, null);
    }

    public static short Default(this IGuard _, short input, string paramName, string message)
    {
        return Guard.Against.Default<short>(input, paramName, message);
    }
}