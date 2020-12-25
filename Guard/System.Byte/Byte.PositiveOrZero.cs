using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard PositiveOrZero(this IGuard _, byte input)
    {
        return Guard.MustBe.PositiveOrZero<byte>(input);
    }

    public static IGuard PositiveOrZero(this IGuard _, byte input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero<byte>(input, paramName);
    }

    public static IGuard PositiveOrZero(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<byte>(input, paramName, message);
    }
}