using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, byte input)
    {
        return Guard.MustBe.NotDefault<byte>(input);
    }

    public static IGuard NotDefault(this IGuard _, byte input, string paramName)
    {
        return Guard.MustBe.NotDefault<byte>(input, paramName);
    }

    public static IGuard NotDefault(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<byte>(input, paramName, message);
    }
}