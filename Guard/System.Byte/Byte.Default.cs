using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static byte Default(this IGuard _, byte input)
    {
        return Guard.MustBe.Default(input, null, null);
    }

    public static byte Default(this IGuard _, byte input, string paramName)
    {
        return Guard.MustBe.Default(input, paramName, null);
    }

    public static byte Default(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.MustBe.Default<byte>(input, paramName, message);
    }
}