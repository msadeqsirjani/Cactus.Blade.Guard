using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static byte NotDefault(this IGuard _, byte input)
    {
        return Guard.MustBe.NotDefault(input, null, null);
    }

    public static byte NotDefault(this IGuard _, byte input, string paramName)
    {
        return Guard.MustBe.NotDefault(input, paramName, null);
    }

    public static byte NotDefault(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<byte>(input, paramName, message);
    }
}