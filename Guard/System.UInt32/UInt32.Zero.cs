using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static uint Zero(this IGuard _, uint input)
    {
        return Guard.Against.Zero(input, null, null);
    }

    public static uint Zero(this IGuard _, uint input, string paramName)
    {
        return Guard.Against.Zero(input, paramName, null);
    }


    public static uint Zero(this IGuard _, uint input, string paramName, string message)
    {
        return Guard.Against.Zero<uint>(input, paramName, message);
    }
}