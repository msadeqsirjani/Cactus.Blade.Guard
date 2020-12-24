using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static byte NotZero(this IGuard _, byte input)
    {
        return Guard.MustBe.NotZero(input, null, null);
    }

    public static byte NotZero(this IGuard _, byte input, string paramName)
    {
        return Guard.MustBe.NotZero(input, paramName, null);
    }


    public static byte NotZero(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.MustBe.NotZero<byte>(input, paramName, message);
    }
}