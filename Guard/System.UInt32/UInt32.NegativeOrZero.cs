using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static uint NegativeOrZero(this IGuard _, uint input)
    {
        return Guard.Against.NegativeOrZero(input, null, null);
    }

    public static uint NegativeOrZero(this IGuard _, uint input, string paramName)
    {
        return Guard.Against.NegativeOrZero(input, paramName, null);
    }

    public static uint NegativeOrZero(this IGuard _, uint input, string paramName, string message)
    {
        return Guard.Against.NegativeOrZero<uint>(input, paramName, message);
    }
}